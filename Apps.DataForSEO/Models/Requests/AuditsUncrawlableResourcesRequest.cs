using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsUncrawlableResourcesRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsUncrawlableResourcesIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"meta.content_type,desc\"] note that you can")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
