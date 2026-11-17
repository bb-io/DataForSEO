using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixGoogleAdsKeywordsDataLimitsRatesDataInfo
{
    [Display("Status")]
    [JsonProperty("status")]
    public double? Status { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixInfo? SearchVolume { get; set; }

    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixInfo? KeywordsForKeywords { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixInfo? KeywordsForSite { get; set; }

    [Display("Ad traffic by keywords")]
    [JsonProperty("ad_traffic_by_keywords")]
    public AppendixInfo? AdTrafficByKeywords { get; set; }
}
