using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDayLimitsRatesData
{
    [Display("SERP")]
    [JsonProperty("serp")]
    public AppendixSerpDaysRatesDataInfo? Serp { get; set; }

    [Display("Total")]
    [JsonProperty("total")]
    public double? Total { get; set; }

    [Display("Total SERP")]
    [JsonProperty("total_serp")]
    public double? TotalSerp { get; set; }

    [Display("Keywords data")]
    [JsonProperty("keywords_data")]
    public AppendixKeywordsDataDaysRatesDataInfo? KeywordsData { get; set; }

    [Display("Total keywords data")]
    [JsonProperty("total_keywords_data")]
    public double? TotalKeywordsData { get; set; }

    [Display("Appendix")]
    [JsonProperty("appendix")]
    public AppendixAppendixDaysRatesDataInfo? Appendix { get; set; }

    [Display("Total appendix")]
    [JsonProperty("total_appendix")]
    public double? TotalAppendix { get; set; }

    [Display("DataForSEO labs")]
    [JsonProperty("dataforseo_labs")]
    public AppendixDataForSEOLabsLimitsRatesDataInfo? DataForSEOLabs { get; set; }

    [Display("Total dataforseo labs")]
    [JsonProperty("total_dataforseo_labs")]
    public double? TotalDataForSEOLabs { get; set; }

    [Display("Domain analytics")]
    [JsonProperty("domain_analytics")]
    public AppendixDomainAnalyticsLimitsRatesDataInfo? DomainAnalytics { get; set; }

    [Display("Total domain analytics")]
    [JsonProperty("total_domain_analytics")]
    public double? TotalDomainAnalytics { get; set; }

    [Display("Merchant")]
    [JsonProperty("merchant")]
    public AppendixMerchantLimitsRatesDataInfo? Merchant { get; set; }

    [Display("Total merchant")]
    [JsonProperty("total_merchant")]
    public double? TotalMerchant { get; set; }

    [Display("On page")]
    [JsonProperty("on_page")]
    public AppendixOnPageLimitsRatesDataInfo? OnPage { get; set; }

    [Display("Total on page")]
    [JsonProperty("total_on_page")]
    public double? TotalOnPage { get; set; }

    [Display("Business data")]
    [JsonProperty("business_data")]
    public AppendixBusinessDataLimitsRatesDataInfo? BusinessData { get; set; }

    [Display("Total business data")]
    [JsonProperty("total_business_data")]
    public double? TotalBusinessData { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public AppendixBacklinksLimitsRatesDataInfo? Backlinks { get; set; }

    [Display("Total backlinks")]
    [JsonProperty("total_backlinks")]
    public double? TotalBacklinks { get; set; }

    [Display("App data")]
    [JsonProperty("app_data")]
    public AppendixAppDataLimitsRatesDataInfo? AppData { get; set; }

    [Display("Total app data")]
    [JsonProperty("total_app_data")]
    public double? TotalAppData { get; set; }

    [Display("Content analysis")]
    [JsonProperty("content_analysis")]
    public AppendixContentAnalysisLimitsRatesDataInfo? ContentAnalysis { get; set; }

    [Display("Total content analysis")]
    [JsonProperty("total_content_analysis")]
    public double? TotalContentAnalysis { get; set; }

    [Display("Ai optimization")]
    [JsonProperty("ai_optimization")]
    public AppendixAiOptimizationLimitsRatesDataInfo? AiOptimization { get; set; }

    [Display("Total ai optimization")]
    [JsonProperty("total_ai_optimization")]
    public double? TotalAiOptimization { get; set; }

    [Display("Total reviews")]
    [JsonProperty("total_reviews")]
    public double? TotalReviews { get; set; }

    [Display("Total social")]
    [JsonProperty("total_social")]
    public double? TotalSocial { get; set; }
}
