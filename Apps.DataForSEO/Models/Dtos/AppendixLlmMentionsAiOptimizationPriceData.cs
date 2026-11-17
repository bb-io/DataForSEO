using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLlmMentionsAiOptimizationPriceData
{
    [Display("Aggregated metrics")]
    [JsonProperty("aggregated_metrics")]
    public AppendixBingKeywordsDataPriceDataInfo? AggregatedMetrics { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Cross aggregated metrics")]
    [JsonProperty("cross_aggregated_metrics")]
    public AppendixBingKeywordsDataPriceDataInfo? CrossAggregatedMetrics { get; set; }

    [Display("Historical")]
    [JsonProperty("historical")]
    public AppendixBingKeywordsDataPriceDataInfo? Historical { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? LocationsAndLanguages { get; set; }

    [Display("Multi target metrics")]
    [JsonProperty("multi_target_metrics")]
    public AppendixBingKeywordsDataPriceDataInfo? MultiTargetMetrics { get; set; }

    [Display("Search")]
    [JsonProperty("search")]
    public AppendixBingKeywordsDataPriceDataInfo? Search { get; set; }

    [Display("Search mentions")]
    [JsonProperty("search_mentions")]
    public AppendixBingKeywordsDataPriceDataInfo? SearchMentions { get; set; }

    [Display("Target metrics")]
    [JsonProperty("target_metrics")]
    public AppendixBingKeywordsDataPriceDataInfo? TargetMetrics { get; set; }

    [Display("Target metrics lite")]
    [JsonProperty("target_metrics_lite")]
    public AppendixBingKeywordsDataPriceDataInfo? TargetMetricsLite { get; set; }

    [Display("Timeseries delta")]
    [JsonProperty("timeseries_delta")]
    public AppendixBingKeywordsDataPriceDataInfo? TimeseriesDelta { get; set; }

    [Display("Timeseries new lost")]
    [JsonProperty("timeseries_new_lost")]
    public AppendixBingKeywordsDataPriceDataInfo? TimeseriesNewLost { get; set; }

    [Display("Top domains")]
    [JsonProperty("top_domains")]
    public AppendixBingKeywordsDataPriceDataInfo? TopDomains { get; set; }

    [Display("Top mentioned brand categories")]
    [JsonProperty("top_mentioned_brand_categories")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedBrandCategories { get; set; }

    [Display("Top mentioned brand categories lite")]
    [JsonProperty("top_mentioned_brand_categories_lite")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedBrandCategoriesLite { get; set; }

    [Display("Top mentioned brands")]
    [JsonProperty("top_mentioned_brands")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedBrands { get; set; }

    [Display("Top mentioned brands lite")]
    [JsonProperty("top_mentioned_brands_lite")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedBrandsLite { get; set; }

    [Display("Top mentioned domains")]
    [JsonProperty("top_mentioned_domains")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedDomains { get; set; }

    [Display("Top mentioned domains lite")]
    [JsonProperty("top_mentioned_domains_lite")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedDomainsLite { get; set; }

    [Display("Top mentioned pages")]
    [JsonProperty("top_mentioned_pages")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedPages { get; set; }

    [Display("Top mentioned pages lite")]
    [JsonProperty("top_mentioned_pages_lite")]
    public AppendixBingKeywordsDataPriceDataInfo? TopMentionedPagesLite { get; set; }

    [Display("Top pages")]
    [JsonProperty("top_pages")]
    public AppendixBingKeywordsDataPriceDataInfo? TopPages { get; set; }
}
