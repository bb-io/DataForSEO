using Apps.DataForSEO.Events;
using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common.Polling;
using Newtonsoft.Json;
using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class PollingTests : TestBase
{
    [TestMethod]
    public async Task FirstRead_BaselinesAndRestoredReadSuppressesDuplicates()
    {
        var events = new TaskPollingList(InvocationContext);
        var first = await events.OnTaskCompleted(new PollingEventRequest<CompletionMemory>(), new TaskEventRequest());
        Assert.IsFalse(first.FlyBird);
        Assert.IsNull(first.Result);
        var memory = JsonConvert.DeserializeObject<CompletionMemory>(JsonConvert.SerializeObject(first.Memory));
        var second = await events.OnTaskCompleted(new PollingEventRequest<CompletionMemory> { Memory = memory }, new TaskEventRequest());
        Assert.IsFalse(second.Result?.Any(x => first.Memory!.SeenTaskIds.Contains(x.TaskId)) ?? false);
        Assert.IsTrue(second.Memory!.LastRead >= first.Memory!.LastRead);
    }
    [TestMethod]
    public async Task FailedRead_DoesNotAdvanceExistingMemory()
    {
        var events = new TaskPollingList(InvocationContext);
        var first = await events.OnTaskCompleted(new PollingEventRequest<CompletionMemory>(), new TaskEventRequest());
        var before = JsonConvert.SerializeObject(first.Memory);
        var invalid = new Blackbird.Applications.Sdk.Common.Invocation.InvocationContext
        {
            AuthenticationCredentialsProviders =
            [
                new Blackbird.Applications.Sdk.Common.Authentication.AuthenticationCredentialsProvider("login", "invalid-test-login"),
                new Blackbird.Applications.Sdk.Common.Authentication.AuthenticationCredentialsProvider("password", "invalid-test-password")
            ]
        };
        await Assert.ThrowsExceptionAsync<Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException>(() =>
            new TaskPollingList(invalid).OnTaskCompleted(new PollingEventRequest<CompletionMemory> { Memory = first.Memory }, new TaskEventRequest()));
        Assert.AreEqual(before, JsonConvert.SerializeObject(first.Memory));
    }
}
