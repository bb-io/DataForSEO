using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleCompetitorsDomainLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Avg position")]
    [JsonProperty("avg_position")]
    public double? AvgPosition { get; set; }

    [Display("Sum position")]
    [JsonProperty("sum_position")]
    public long? SumPosition { get; set; }

    [Display("Intersections")]
    [JsonProperty("intersections")]
    public long? Intersections { get; set; }

    [Display("Full domain metrics")]
    [JsonProperty("full_domain_metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? FullDomainMetrics { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Metrics { get; set; }

    [Display("Competitor metrics")]
    [JsonProperty("competitor_metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? CompetitorMetrics { get; set; }
}
