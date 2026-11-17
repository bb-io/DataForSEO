using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBingKeywordsDataPriceData
{
    [Display("Audience estimation")]
    [JsonProperty("audience_estimation")]
    public AppendixBingKeywordsDataPriceDataInfo? AudienceEstimation { get; set; }

    [Display("Keyword performance")]
    [JsonProperty("keyword_performance")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordPerformance { get; set; }

    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForKeywords { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForSite { get; set; }

    [Display("Keyword suggestions for URL")]
    [JsonProperty("keyword_suggestions_for_url")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordSuggestionsForUrl { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? SearchVolume { get; set; }
}
