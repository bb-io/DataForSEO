using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsRawHtmlRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsRawHtmlIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("URL", Description = "page url required field the absolute URL of a page to request HTML Note: this field is optional if the task was set using the Instant Pages endpoint")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;
}
