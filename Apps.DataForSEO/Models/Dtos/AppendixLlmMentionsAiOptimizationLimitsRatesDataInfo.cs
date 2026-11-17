using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLlmMentionsAiOptimizationLimitsRatesDataInfo
{
    [Display("Search")]
    [JsonProperty("search")]
    public AppendixInfo? Search { get; set; }

    [Display("Aggregated metrics")]
    [JsonProperty("aggregated_metrics")]
    public AppendixInfo? AggregatedMetrics { get; set; }

    [Display("Cross aggregated metrics")]
    [JsonProperty("cross_aggregated_metrics")]
    public AppendixInfo? CrossAggregatedMetrics { get; set; }

    [Display("Top domains")]
    [JsonProperty("top_domains")]
    public AppendixInfo? TopDomains { get; set; }

    [Display("Top pages")]
    [JsonProperty("top_pages")]
    public AppendixInfo? TopPages { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public double? LocationsAndLanguages { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("Search mentions")]
    [JsonProperty("search_mentions")]
    public AppendixInfo? SearchMentions { get; set; }

    [Display("Target metrics")]
    [JsonProperty("target_metrics")]
    public AppendixInfo? TargetMetrics { get; set; }

    [Display("Multi target metrics")]
    [JsonProperty("multi_target_metrics")]
    public AppendixInfo? MultiTargetMetrics { get; set; }

    [Display("Top mentioned domains")]
    [JsonProperty("top_mentioned_domains")]
    public AppendixInfo? TopMentionedDomains { get; set; }

    [Display("Top mentioned pages")]
    [JsonProperty("top_mentioned_pages")]
    public AppendixInfo? TopMentionedPages { get; set; }

    [Display("Top mentioned brands")]
    [JsonProperty("top_mentioned_brands")]
    public AppendixInfo? TopMentionedBrands { get; set; }

    [Display("Top mentioned brand categories")]
    [JsonProperty("top_mentioned_brand_categories")]
    public AppendixInfo? TopMentionedBrandCategories { get; set; }

    [Display("Target metrics lite")]
    [JsonProperty("target_metrics_lite")]
    public AppendixInfo? TargetMetricsLite { get; set; }

    [Display("Top mentioned domains lite")]
    [JsonProperty("top_mentioned_domains_lite")]
    public AppendixInfo? TopMentionedDomainsLite { get; set; }

    [Display("Top mentioned pages lite")]
    [JsonProperty("top_mentioned_pages_lite")]
    public AppendixInfo? TopMentionedPagesLite { get; set; }

    [Display("Top mentioned brands lite")]
    [JsonProperty("top_mentioned_brands_lite")]
    public AppendixInfo? TopMentionedBrandsLite { get; set; }

    [Display("Top mentioned brand categories lite")]
    [JsonProperty("top_mentioned_brand_categories_lite")]
    public AppendixInfo? TopMentionedBrandCategoriesLite { get; set; }

    [Display("Historical")]
    [JsonProperty("historical")]
    public AppendixInfo? Historical { get; set; }

    [Display("Timeseries delta")]
    [JsonProperty("timeseries_delta")]
    public AppendixInfo? TimeseriesDelta { get; set; }

    [Display("Timeseries new lost")]
    [JsonProperty("timeseries_new_lost")]
    public AppendixInfo? TimeseriesNewLost { get; set; }
}
