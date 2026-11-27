using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsResourcesRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsResourcesIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("URL", Description = "page URL optional field specify this field if you want to get the resources for a specific page note that to obtain resource's meta from a particular URL, you should specify the URL in this field; if you do not indicate a url when setting a task, resource's meta in the results will be returned based on the data from the page where our cra")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Relevant pages filters", Description = "filter the resources by relevant pages optional field you can use this field to obtain resources from pages matching to the defined parameters you can apply the same filters here as available for the pages endpoint you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the")]
    [JsonProperty("relevant_pages_filters")]
    public List<string>? RelevantPagesFilters { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"size,desc\"] note that you can set no more ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
