using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleCompetitorsDomainLiveRequest
{
    [Display("Target", Description = "domain required field the domain name of the target website the domain should be specified without https:// and www. you can specify page URL, but the results will be specific to the domain in the specified URL")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleCompetitorsDomainLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleCompetitorsDomainLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Item types", Description = "display results by item type optional field indicates the type of search results included in the response Note: if the item_types array contains item types that are different from organic , the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not in")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to_ true , you will receive clickstream_etv , clickstream_gender_distribution , and_ clickstream_age_distribution _fields with clickstream data in the response default value: false with this parameter enabled, you will be charged do")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to specify a sorting type example: [\"metrics.paid.etv,asc\"] Note: you can set ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Max rank group", Description = "maximum rank up to which competitors will be considered optional field default value: 100 if you specify 10 here, we will extract competitors from the top 10 Google search results only")]
    [JsonProperty("max_rank_group")]
    public long? MaxRankGroup { get; set; }

    [Display("Exclude top domains", Description = "indicates whether to exclude world's largest websites optional field default value: false set to true if you want to get highly-relevant competitors excluding the websites listed below: wikipedia.org pinterest.com amazon.com google.com facebook.com wordpress.com medium.com quora.com reddit.com youtube.com ebay.com uol.com.br instagram.com")]
    [JsonProperty("exclude_top_domains")]
    public bool? ExcludeTopDomains { get; set; }

    [Display("Exclude domains", Description = "exclude domains from the results optional field use this parameter to exclude specific domains from the results Note: you can specify up to 1000 domains in this array example: \"exclude_domains\": [ \"reddit.com\", \"youtube.com\" ]")]
    [JsonProperty("exclude_domains")]
    public List<string>? ExcludeDomains { get; set; }

    [Display("Intersecting domains", Description = "additional domains for improving results accuracy optional field to improve the accuracy of the result, you can specify domains that are known to intersect with the target in SERPs; if you use this array, metrics in the result will be based on SERPs where both target website and intersecting_domains appear; Note: you can specify up to 20 ")]
    [JsonProperty("intersecting_domains")]
    public List<string>? IntersectingDomains { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to_ true , only core keywords will be returned, all highly similar keywords will be excluded; default value: false n")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
