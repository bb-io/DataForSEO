using Apps.DataForSEO.Api;
using Apps.DataForSEO.Events;
using Apps.DataForSEO.Models.Requests;
using Apps.DataForSEO.Models.Responses;
using Blackbird.Applications.Sdk.Common.Webhooks;
using Newtonsoft.Json.Linq;
using RestSharp;
using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class CallbackTests : TestBase
{
    [TestMethod]
    public async Task CompletedTask_CallbackVerifiesConnectedAccount()
    {
        var created = await Run("SerpGoogleOrganicTaskPost");
        var outcomes = (List<TaskOutcome>)created.GetType().GetProperty("Tasks")!.GetValue(created)!;
        var id = outcomes.First().TaskId;
        using var client = new DataForSEOClient(InvocationContext.AuthenticationCredentialsProviders);
        var ready = false;
        for (var attempt = 0; attempt < 36; attempt++)
        {
            var status = await client.Read<JToken>(new RestRequest("/v3/serp/google/organic/task_get/advanced/" + Uri.EscapeDataString(id)));
            if (status.Tasks.All(x => x.StatusCode == 20000))
            {
                ready = true;
                break;
            }
            await Task.Delay(TimeSpan.FromSeconds(5));
        }
        Assert.IsTrue(ready, "Task did not complete within the integration-test wait window.");
        var result = await new TaskCallbackList(InvocationContext).OnTaskCallback(new WebhookRequest
        {
            HttpMethod = HttpMethod.Get,
            QueryParameters = new Dictionary<string, string> { ["id"] = id }
        }, new TaskEventRequest());
        Assert.AreEqual(id, result.Result!.TaskId);
    }
}
