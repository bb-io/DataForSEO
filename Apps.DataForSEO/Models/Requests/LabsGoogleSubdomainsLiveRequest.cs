using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleSubdomainsLiveRequest
{
    [Display("Target", Description = "domain required field the domain name of the target website the domain should be specified without https:// and www.")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleSubdomainsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleSubdomainsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Item types", Description = "display results by item type optional field indicates the type of search results included in the response Note: if the item_types array contains item types that are different from organic , the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not in")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to true , you will receive clickstream_etv , clickstream_gender_distribution , and clickstream_age_distribution fields with clickstream data in the response default value: false with this parameter enabled, you will be charged doubl")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Historical SERP mode", Description = "data collection mode optional field you can use this field to filter the results; possible types of filtering: live \u2014 return metrics for SERPs in which the specified target currently has ranking results; lost \u2014 return metrics for SERPs in which the specified target had previously had ranking results, but didn't have them during the last c")]
    [JsonProperty("historical_serp_mode")]
    public string? HistoricalSerpMode { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to true , only core keywords will be returned, all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to specify a sorting type example: [\"metrics.paid.etv,asc\"] Note: you can set ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
