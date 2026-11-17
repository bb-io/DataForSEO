using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGooglePageIntersectionLiveRequest
{
    [Display("Pages JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. target URLs of pagesrequired fieldyou can set up to 20 pages in this objectthe pages should be specified with absolute URLs (including http:// or https://)example:\"pages\": {\"1\":\"ht")]
    [JsonProperty("pages")]
    public string PagesJson { get; set; } = string.Empty;

    [Display("Exclude pages", Description = "URLs of pages you want to excludeoptional fieldyou can set up to 10 pages in this arrayif you use this array, results will contain the keywords for which URLs from the pages object rank, but URLs from exclude_pages array do not;note that if you specify this field, the results will be based on the keywords any URL from pages ranks for rega")]
    [JsonProperty("exclude_pages")]
    public List<string>? ExcludePages { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Item types", Description = "search results typeindicates type of search results included in the responseoptional fieldpossible values: [\"organic\", \"paid\", \"featured_snippet\", \"local_pack\", \"ai_overview_reference\"]default value: [\"organic\", \"paid\"]")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Include subdomains", Description = "indicates if the subdomains will be included in the searchoptional fieldif set to false, the subdomains will be ignoreddefault value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Intersection mode", Description = "indicates whether to intersect keywordsoptional fielduse this field to intersect or merge results for the specified URLspossible values: union, intersectunion - results are based on all keywords any URL from pages rank for;intersect - results are based on the keywords all URLs from pages rank for in the same SERP:by default, results are b")]
    [JsonProperty("intersection_mode")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.LabsGooglePageIntersectionLiveIntersectionModeCatalogue))]
    public string? IntersectionMode { get; set; }

    [Display("Include SERP info", Description = "include data from SERP for each keywordoptional fieldif set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the responsedefault value: false")]
    [JsonProperty("include_serp_info")]
    public bool? IncludeSerpInfo { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the resultoptional fieldif the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the responsedefault value: falsewith this parameter enabled, you will be ch")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywordsoptional fieldif set to true only core keywords will be returned, all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe follow")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting parameterexample:[\"keyword_data.keyword_info.competition,desc\"]d")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
