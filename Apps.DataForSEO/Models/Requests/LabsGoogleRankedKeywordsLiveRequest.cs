using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleRankedKeywordsLiveRequest
{
    [Display("Target", Description = "domain name or page url required field the domain name of the target website, subdomain or URL of the target webpage; the domain name must be specified without https:// or www. ; the subdomain must be specified without https:// ; the webpage URL must be specified with https:// or www. Note: if you specify the webpage URL without https:// ")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleRankedKeywordsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleRankedKeywordsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to true only core keywords will be returned, all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Item types", Description = "display results by item type optional field indicates the type of search results included in the response Note: if the item_types array contains item types that are different from organic , the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not in")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to true , you will receive clickstream_keyword_info , clickstream_etv , clickstream_gender_distribution , clickstream_age_distribution , keyword_info_normalized_with_clickstream , and keyword_info_normalized_with_bing fields in the ")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Load rank absolute", Description = "return rankings distribution by rank_absolute optional field default value: false if set to true , we will return the field metrics_absolute containing rankings distribution by the rank_absolute parameter that indicates the result\u2019s position among all SERP elements")]
    [JsonProperty("load_rank_absolute")]
    public bool? LoadRankAbsolute { get; set; }

    [Display("Historical SERP mode", Description = "data collection mode optional field you can use this field to filter the results; possible types of filtering: live \u2014 return keywords for which the specified target currently has ranking results in SERP; lost \u2014 return keywords for which the specified target had previously had ranking results in SERP, but didn't have them during the last c")]
    [JsonProperty("historical_serp_mode")]
    public string? HistoricalSerpMode { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"keyword_data.keyword_info.competition,desc")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
