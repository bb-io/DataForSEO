using System.Text;
using Apps.DataForSEO.Models.Dtos;
using Apps.DataForSEO.Models.Responses;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Apps.DataForSEO.Utils;

public static class ReportWriter
{
    public static async Task<ReportResponse<T>> Write<T>(IFileManagementClient files, List<RestResponse> responses, string name, bool paginated)
    {
        try
        {
            var envelopes = responses.Select(x => JsonConvert.DeserializeObject<EnvelopeDto<JToken>>(x.Content!)!).ToList();
            var raw = envelopes.SelectMany(x => x.Tasks).SelectMany(x => x.Result ?? []).ToList();
            if (paginated && raw.Count > 1)
            {
                var first = (JObject)raw[0].DeepClone();
                var items = new JArray(raw.SelectMany(x => x["items"] as JArray ?? []));
                first["items"] = items;
                first["items_count"] = items.Count;
                raw = [first];
            }
            var contentFiles = new List<Blackbird.Applications.Sdk.Common.Files.FileReference>();
            var htmlIndex = 0;
            foreach (var html in raw.SelectMany(x => x.SelectTokens("$..html")).Where(x => x.Type == JTokenType.String))
            {
                using var htmlStream = new MemoryStream(Encoding.UTF8.GetBytes(html.Value<string>()!));
                contentFiles.Add(await FileTransfer.Upload(files, htmlStream, "text/html", $"{name}-{++htmlIndex}.html"));
            }
            if (typeof(T).Name is "SerpScreenshotResultInfo" or "OnPagePageScreenshotResultInfo")
            {
                var screenshotIndex = 0;
                foreach (var url in raw.SelectMany(x => x.SelectTokens("$.items[*].image")).Values<string>())
                    if (url != null)
                        contentFiles.Add(await FileTransfer.DownloadScreenshot(files, url, $"{name}-{++screenshotIndex}"));
            }
            var results = raw.Select(x => x.ToObject<T>()!).ToList();
            var tasks = envelopes.SelectMany(x => x.Tasks).Select(x => new TaskOutcome
            {
                TaskId = x.Id,
                StatusCode = x.StatusCode,
                StatusMessage = x.StatusMessage,
                Cost = (double)x.Cost,
                Ready = x.StatusCode == 20000 && x.Result != null && !x.Result.Any(r => r["crawl_progress"]?.Value<string>() == "in_progress")
            }).ToList();
            using var stream = new MemoryStream(Encoding.UTF8.GetBytes("[" + string.Join(",", responses.Select(x => x.Content)) + "]"));
            return new ReportResponse<T>
            {
                Results = results,
                ContentFiles = contentFiles,
                Tasks = tasks,
                Cost = (double)envelopes.Sum(x => x.Cost),
                File = await FileTransfer.Upload(files, stream, "application/json", name + ".json")
            };
        }
        catch (JsonException)
        {
            throw new PluginApplicationException("DataForSEO returned results that could not be decoded. Check the task in your account before repeating a paid request.");
        }
    }
}
