using System.Reflection;
using Apps.DataForSEO.Models.Responses;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Files;
using Blackbird.Applications.Sdk.Common.Invocation;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tests.DataForSEO.Base;

public class TestBase
{
    protected InvocationContext InvocationContext { get; }

    protected FileManager FileManager { get; } = new();

    protected JObject Examples { get; }

    protected TestBase()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json").Build();
        InvocationContext = new InvocationContext
        {
            AuthenticationCredentialsProviders = configuration.GetSection("ConnectionDefinition").GetChildren()
                .Select(x => new AuthenticationCredentialsProvider(x.Key, x.Value ?? string.Empty)).ToList()
        };
        Examples = JObject.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "ActionExamples.json")));
    }

    protected async Task<object> Run(string name)
    {
        var example = Examples[name]!;
        var assembly = typeof(Apps.DataForSEO.Application).Assembly;
        var actionType = assembly.GetType("Apps.DataForSEO.Actions." + example["actionType"]!.Value<string>())!;
        var requestType = assembly.GetType("Apps.DataForSEO.Models.Requests." + example["requestType"]!.Value<string>())!;
        var method = actionType.GetMethod(name)!;
        var source = (example["input"] as JArray)?.FirstOrDefault() as JObject ?? new JObject();
        source = (JObject)source.DeepClone();
        source.Remove("pingback_url");
        source.Remove("postback_url");
        source.Remove("location_name");
        source.Remove("language_name");
        source["limit"] = 1;
        source["MaximumResults"] = 1;
        if (requestType.GetProperty("LocationCode") != null && source["location_code"] == null)
            source["location_code"] = "2840";
        if (requestType.GetProperty("LanguageCode") != null && source["language_code"] == null)
            source["language_code"] = "en";
        if (source["max_crawl_pages"] != null)
        {
            source["target"] = "example.com";
            source["max_crawl_pages"] = 1;
            source["store_raw_html"] = true;
            source["enable_content_parsing"] = true;
        }
        var path = example["path"]!.Value<string>()!;
        if (requestType.GetProperty("TaskId") != null)
        {
            var submissionPath = path.StartsWith("/v3/serp/") && !path.Contains("/task_get/") ? "/v3/serp/google/organic/task_post" : path.Contains("/task_get/") ? path.Split("/task_get/")[0] + "/task_post" : "/v3/on_page/task_post";
            var submission = Examples.Properties().First(x => x.Value["path"]?.Value<string>() == submissionPath);
            var created = await Run(submission.Name);
            var tasks = (List<TaskOutcome>)created.GetType().GetProperty("Tasks")!.GetValue(created)!;
            source["id"] = tasks.First().TaskId;
            source["task_id"] = tasks.First().TaskId;
        }
        foreach (var property in requestType.GetProperties())
        {
            var key = property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? property.Name;
            if (property.PropertyType == typeof(string) && source[key] is JContainer nested)
                source[key] = nested.ToString(Formatting.None);
        }
        var input = source.ToObject(requestType)!;
        var action = Activator.CreateInstance(actionType, InvocationContext, FileManager)!;
        object result = null!;
        for (var attempt = 0; attempt < 36; attempt++)
        {
            Task task;
            try
            {
                task = (Task)method.Invoke(action, [input])!;
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException ?? ex;
            }
            await task;
            result = task.GetType().GetProperty("Result")!.GetValue(task)!;
            var outcomes = (List<TaskOutcome>)result.GetType().GetProperty("Tasks")!.GetValue(result)!;
            Assert.IsTrue(outcomes.Count > 0, "Provider did not return a task outcome.");
            Assert.IsTrue(outcomes.All(x => x.StatusCode is 20000 or 20100 or 40601 or 40602));
            if (requestType.GetProperty("TaskId") == null || path.EndsWith("/force_stop") || outcomes.All(x => x.Ready))
                break;
            await Task.Delay(TimeSpan.FromSeconds(5));
        }
        if (requestType.GetProperty("TaskId") != null && !path.EndsWith("/force_stop"))
        {
            var completed = (List<TaskOutcome>)result.GetType().GetProperty("Tasks")!.GetValue(result)!;
            Assert.IsTrue(completed.All(x => x.Ready), "Task did not become ready within the integration-test wait window.");
        }
        var file = (FileReference)result.GetType().GetProperty("File")!.GetValue(result)!;
        Assert.IsTrue(File.Exists(Path.Combine(FileManager.Folder, file.Name)));
        Assert.IsTrue(new FileInfo(Path.Combine(FileManager.Folder, file.Name)).Length > 2);
        return result;
    }
}
