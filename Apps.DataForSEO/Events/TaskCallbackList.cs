using System.Net;
using Apps.DataForSEO.Constants;
using Apps.DataForSEO.Models.Requests;
using Apps.DataForSEO.Models.Responses;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Webhooks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Apps.DataForSEO.Events;

[WebhookList("Task callbacks")]
public class TaskCallbackList(InvocationContext context) : Invocable(context)
{
    [Webhook("On SEO task callback", Description = "Receive a per-task GET pingback and verify completion with the connected account. Repeated deliveries may start repeated Flights.")]
    public async Task<WebhookResponse<ReadyTaskResponse>> OnTaskCallback(WebhookRequest request, [WebhookParameter] TaskEventRequest input)
    {
        var family = TaskFamilies.Get(input.Family);
        if (!family.SupportsPingback)
            throw new PluginMisconfigurationException("This task family does not support GET pingbacks. Use the polling trigger.");
        if (request.HttpMethod != HttpMethod.Get || request.QueryParameters == null || !request.QueryParameters.TryGetValue("id", out var id) || !Guid.TryParse(id, out _))
            return Preflight();
        var response = await Client.Read<JToken>(new RestRequest(family.ResultPath.Replace("{id}", Uri.EscapeDataString(id))));
        var result = response.Tasks.FirstOrDefault();
        if (result == null || result.StatusCode != 20000 || result.Result == null)
            return Preflight();
        var tag = result.Data?.Tag;
        if (input.Tag != null && input.Tag != tag)
            return Preflight();
        if (input.Family == "on_page" && result.Result.FirstOrDefault()?["crawl_progress"]?.Value<string>() != "finished")
            return Preflight();
        return new()
        {
            HttpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK),
            Result = new ReadyTaskResponse { TaskId = id, Tag = tag, Family = input.Family ?? "serp/google/organic" }
        };
    }

    private static WebhookResponse<ReadyTaskResponse> Preflight() => new()
    {
        HttpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK),
        ReceivedWebhookRequestType = WebhookRequestType.Preflight,
        Result = null
    };
}
