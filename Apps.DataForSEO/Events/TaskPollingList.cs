using System.Security.Cryptography;
using System.Text;
using Apps.DataForSEO.Constants;
using Apps.DataForSEO.Models.Dtos;
using Apps.DataForSEO.Models.Requests;
using Apps.DataForSEO.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Polling;
using RestSharp;

namespace Apps.DataForSEO.Events;

[PollingEventList("Task completion")]
public class TaskPollingList(InvocationContext context) : Invocable(context)
{
    [PollingEvent("On SEO task completed", Description = "Detect uncollected completed tasks. Shared queue; other consumers can cause missed events. First poll establishes a baseline.")]
    [MultipleEvents]
    public async Task<PollingEventResponse<CompletionMemory, List<ReadyTaskResponse>>> OnTaskCompleted(
        PollingEventRequest<CompletionMemory> request,
        [PollingEventParameter] TaskEventRequest input)
    {
        var family = TaskFamilies.Get(input.Family);
        var identity = string.Join("|", InvocationContext.AuthenticationCredentialsProviders.OrderBy(x => x.KeyName).Select(x => x.KeyName + "=" + x.Value));
        var scope = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(identity + family.ReadyPath + input.Tag)));
        var now = DateTime.UtcNow;
        if (request.Memory != null && request.Memory.Scope == scope && now - request.Memory.LastRead > TimeSpan.FromDays(3))
            throw new PluginApplicationException("The task polling gap exceeds three days. The provider may have expired events. Reconcile task history and reset this trigger before resuming.");
        var envelope = await Client.Read<ReadyTaskDto>(new RestRequest(family.ReadyPath));
        var allRows = envelope.Tasks.SelectMany(x => x.Result ?? []).DistinctBy(x => x.Id).ToList();
        if (allRows.Count >= 1000)
            throw new PluginApplicationException("The provider task queue reached 1,000 entries and may be incomplete. Collect completed tasks or use per-task callbacks before resuming polling.");
        var rows = allRows.Where(x => input.Tag == null || x.Tag == input.Tag).ToList();
        if (request.Memory == null || request.Memory.Scope != scope)
            return new()
            {
                FlyBird = false,
                Result = null,
                Memory = new CompletionMemory { LastRead = now, Scope = scope, SeenTaskIds = rows.Select(x => x.Id).ToList() }
            };
        var seen = request.Memory.SeenTaskIds.ToHashSet(StringComparer.Ordinal);
        var fresh = rows.Where(x => !seen.Contains(x.Id)).Take(100).ToList();
        var current = rows.Select(x => x.Id).ToHashSet(StringComparer.Ordinal);
        return new()
        {
            FlyBird = fresh.Count > 0,
            Result = fresh.Count == 0 ? null : fresh.Select(x => new ReadyTaskResponse { TaskId = x.Id, Tag = x.Tag, Family = input.Family ?? "serp/google/organic" }).ToList(),
            Memory = new CompletionMemory
            {
                LastRead = now,
                Scope = scope,
                SeenTaskIds = seen.Where(current.Contains).Concat(fresh.Select(x => x.Id)).Distinct().ToList()
            }
        };
    }
}
