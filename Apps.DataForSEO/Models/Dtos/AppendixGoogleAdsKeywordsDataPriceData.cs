using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixGoogleAdsKeywordsDataPriceData
{
    [Display("Ad traffic by keywords")]
    [JsonProperty("ad_traffic_by_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? AdTrafficByKeywords { get; set; }

    [Display("Keywords for keywords")]
    [JsonProperty("keywords_for_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForKeywords { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForSite { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? SearchVolume { get; set; }

    [Display("Status")]
    [JsonProperty("status")]
    public AppendixTaskKeywordsDataPriceDataInfo? Status { get; set; }
}
