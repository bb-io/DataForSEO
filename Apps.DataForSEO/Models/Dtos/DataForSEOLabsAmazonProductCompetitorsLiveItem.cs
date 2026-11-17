using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsAmazonProductCompetitorsLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Asin")]
    [JsonProperty("asin")]
    public string? Asin { get; set; }

    [Display("Avg position")]
    [JsonProperty("avg_position")]
    public double? AvgPosition { get; set; }

    [Display("Sum position")]
    [JsonProperty("sum_position")]
    public long? SumPosition { get; set; }

    [Display("Intersections")]
    [JsonProperty("intersections")]
    public long? Intersections { get; set; }

    [Display("Competitor metrics")]
    [JsonProperty("competitor_metrics")]
    public AmazonMetricsBundleInfo? CompetitorMetrics { get; set; }

    [Display("Full metrics")]
    [JsonProperty("full_metrics")]
    public AmazonMetricsBundleInfo? FullMetrics { get; set; }
}
