using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixKeywordsDataDaysRatesDataInfo
{
    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixInfo? KeywordsForKeywords { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixInfo? KeywordsForSite { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixInfo? SearchVolume { get; set; }

    [Display("Ad traffic by keywords")]
    [JsonProperty("ad_traffic_by_keywords")]
    public AppendixInfo? AdTrafficByKeywords { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Explore")]
    [JsonProperty("explore")]
    public AppendixInfo? Explore { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public double? Categories { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Bing")]
    [JsonProperty("bing")]
    public AppendixBingKeywordsDataLimitsRatesDataInfo? Bing { get; set; }

    [Display("Keyword performance")]
    [JsonProperty("keyword_performance")]
    public AppendixInfo? KeywordPerformance { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public double? LocationsAndLanguages { get; set; }

    [Display("Google ads")]
    [JsonProperty("google_ads")]
    public AppendixGoogleAdsKeywordsDataLimitsRatesDataInfo? GoogleAds { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("DataForSEO trends")]
    [JsonProperty("dataforseo_trends")]
    public AppendixDataForSEOTrendsKeywordsDataLimitsRatesDataInfo? DataForSEOTrends { get; set; }

    [Display("Clickstream data")]
    [JsonProperty("clickstream_data")]
    public AppendixClickstreamDataKeywordsDataLimitsRatesDataInfo? ClickstreamData { get; set; }

    [Display("Audience estimation")]
    [JsonProperty("audience_estimation")]
    public AppendixInfo? AudienceEstimation { get; set; }

    [Display("Keyword suggestions for URL")]
    [JsonProperty("keyword_suggestions_for_url")]
    public AppendixInfo? KeywordSuggestionsForUrl { get; set; }
}
