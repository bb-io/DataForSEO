using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsRedirectChainsRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsRedirectChainsIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("URL", Description = "page URL optional field absolute URL of the target page if you use this field, the API response will return only redirect chains which contain the specified URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can use only one filtering parameter with this endpoint the following filtering parameter is supported: is_redirect_loop th")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
