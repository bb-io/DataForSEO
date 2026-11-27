using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsDuplicateTagsRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsDuplicateTagsIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Type", Description = "type of element")]
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [Display("Accumulator", Description = "tag value optional field specify a title or description here if you want to receive a list of duplicate pages that contains this tag")]
    [JsonProperty("accumulator")]
    public string? Accumulator { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
