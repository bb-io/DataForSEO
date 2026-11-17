using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsPagesRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsPagesIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe follow")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting typeexample:[\"meta.external_links_count,desc\"]note that you can ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
