using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixKeywordsDataPriceData
{
    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }

    [Display("Ad traffic by keywords")]
    [JsonProperty("ad_traffic_by_keywords")]
    public AppendixAKeywordsDataPriceDataInfo? AdTrafficByKeywords { get; set; }

    [Display("Audience estimation")]
    [JsonProperty("audience_estimation")]
    public AppendixAKeywordsDataPriceDataInfo? AudienceEstimation { get; set; }

    [Display("Bing")]
    [JsonProperty("bing")]
    public AppendixBingKeywordsDataPriceData? Bing { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public AppendixTaskKeywordsDataPriceDataInfo? Categories { get; set; }

    [Display("Clickstream data")]
    [JsonProperty("clickstream_data")]
    public AppendixClickstreamDataKeywordsDataPriceData? ClickstreamData { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("Google ads")]
    [JsonProperty("google_ads")]
    public AppendixGoogleAdsKeywordsDataPriceData? GoogleAds { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Keyword performance")]
    [JsonProperty("keyword_performance")]
    public AppendixAKeywordsDataPriceDataInfo? KeywordPerformance { get; set; }

    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixAKeywordsDataPriceDataInfo? KeywordsForKeywords { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixAKeywordsDataPriceDataInfo? KeywordsForSite { get; set; }

    [Display("Keyword suggestions for URL")]
    [JsonProperty("keyword_suggestions_for_url")]
    public AppendixAKeywordsDataPriceDataInfo? KeywordSuggestionsForUrl { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? LocationsAndLanguages { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixAKeywordsDataPriceDataInfo? SearchVolume { get; set; }

    [Display("DataForSEO trends")]
    [JsonProperty("dataforseo_trends")]
    public AppendixDataForSEOTrendsKeywordsDataPriceData? DataForSEOTrends { get; set; }

    [Display("Explore")]
    [JsonProperty("explore")]
    public AppendixExploreKeywordsDataPriceData? Explore { get; set; }
}
