using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixPriceData
{
    [Display("Keywords data")]
    [JsonProperty("keywords_data")]
    public AppendixKeywordsDataPriceData? KeywordsData { get; set; }

    [Display("Merchant")]
    [JsonProperty("merchant")]
    public AppendixMerchantPriceData? Merchant { get; set; }

    [Display("Ai optimization")]
    [JsonProperty("ai_optimization")]
    public AppendixAiOptimizationPriceData? AiOptimization { get; set; }

    [Display("SERP")]
    [JsonProperty("serp")]
    public AppendixSerpPriceData? Serp { get; set; }

    [Display("Appendix")]
    [JsonProperty("appendix")]
    public AppendixAppendixPriceData? Appendix { get; set; }

    [Display("App data")]
    [JsonProperty("app_data")]
    public AppendixAppDataPriceData? AppData { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public AppendixBacklinksPriceData? Backlinks { get; set; }

    [Display("Business data")]
    [JsonProperty("business_data")]
    public AppendixBusinessDataPriceData? BusinessData { get; set; }

    [Display("Content analysis")]
    [JsonProperty("content_analysis")]
    public AppendixContentAnalysisPriceData? ContentAnalysis { get; set; }

    [Display("DataForSEO labs")]
    [JsonProperty("dataforseo_labs")]
    public AppendixDataForSEOLabsPriceData? DataForSEOLabs { get; set; }

    [Display("Domain analytics")]
    [JsonProperty("domain_analytics")]
    public AppendixDomainAnalyticsPriceData? DomainAnalytics { get; set; }

    [Display("On page")]
    [JsonProperty("on_page")]
    public AppendixOnPagePriceData? OnPage { get; set; }
}
