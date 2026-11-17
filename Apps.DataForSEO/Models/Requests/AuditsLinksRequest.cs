using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsLinksRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsLinksIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Page from", Description = "relative page URL optional field if you use this field, the API response will contain only links from the specified page note that in this field you can specify relative URLs only")]
    [JsonProperty("page_from")]
    public string? PageFrom { get; set; }

    [Display("Page to", Description = "relative page URL optional field if you use this field, the API response will contain only internal links pointing to the specified page note that in this field you can specify relative URLs only")]
    [JsonProperty("page_to")]
    public string? PageTo { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
