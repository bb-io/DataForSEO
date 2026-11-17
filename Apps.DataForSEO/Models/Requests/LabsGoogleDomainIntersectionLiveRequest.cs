using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleDomainIntersectionLiveRequest
{
    [Display("Target1", Description = "domain required field the domain name of the first target website the domain should be specified without https:// and www.")]
    [JsonProperty("target1")]
    public string Target1 { get; set; } = string.Empty;

    [Display("Target2", Description = "domain required field the domain name of the second target website the domain should be specified without https:// and www.")]
    [JsonProperty("target2")]
    public string Target2 { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleDomainIntersectionLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleDomainIntersectionLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Intersections", Description = "domain intersections in SERP optional field if you set intersections to true, you will get the keywords for which both target domains specified as target1 and target2 have results within the same SERP; the corresponding SERP elements for both domains will be provided in the results array Note: this endpoint will not provide results if the")]
    [JsonProperty("intersections")]
    public bool? Intersections { get; set; }

    [Display("Item types", Description = "search results type indicates type of search results included in the response optional field possible values: [\"organic\", \"paid\", \"featured_snippet\", \"local_pack\"] default value: [\"organic\", \"paid\"]")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Include SERP info", Description = "include data from SERP for each keyword optional field if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response default value: false")]
    [JsonProperty("include_serp_info")]
    public bool? IncludeSerpInfo { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the response default value: false with this parameter enabled, you will b")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and, or between the conditions the fo")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting parameter example: [\"keyword_data.keyword_info.competition")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
