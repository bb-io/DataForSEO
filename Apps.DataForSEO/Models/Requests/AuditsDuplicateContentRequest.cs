using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsDuplicateContentRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsDuplicateContentIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("URL", Description = "page URL required field specify the initial page you want to receive duplicate content for")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("Similarity", Description = "content similarity score by default, the content is considered duplicate if the value is greater than or equals 6 you can specify any similarity score in the 0-to-10 range")]
    [JsonProperty("similarity")]
    public long? Similarity { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
