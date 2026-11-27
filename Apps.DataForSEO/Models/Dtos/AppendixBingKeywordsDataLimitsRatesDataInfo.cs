using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBingKeywordsDataLimitsRatesDataInfo
{
    [Display("Keyword performance")]
    [JsonProperty("keyword_performance")]
    public AppendixInfo? KeywordPerformance { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixInfo? SearchVolume { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixInfo? KeywordsForSite { get; set; }

    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixInfo? KeywordsForKeywords { get; set; }

    [Display("Audience estimation")]
    [JsonProperty("audience_estimation")]
    public AppendixInfo? AudienceEstimation { get; set; }

    [Display("Keyword suggestions for URL")]
    [JsonProperty("keyword_suggestions_for_url")]
    public AppendixInfo? KeywordSuggestionsForUrl { get; set; }
}
