using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsKeywordDensityRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsKeywordDensityIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Keyword length", Description = "number of words for a keyword required field possible values: 1 , 2 , 3 , 4 , 5")]
    [JsonProperty("keyword_length")]
    public long KeywordLength { get; set; }

    [Display("URL", Description = "page URL optional field if you do not specify a page here, the results will be provided for the whole website if you use this field, the API response will contain only keywords from the specified page a page should be specified with absolute URL (including http:// or https:// )")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Limit", Description = "the maximum number of returned keywords optional field default value: 100 maximum value: 1000")]
    [JsonProperty("limit")]
    public long? Limit { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"frequency,desc\"] note that you can set no ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
