using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleDomainMetricsByCategoriesLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Top categories")]
    [JsonProperty("top_categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> TopCategories { get; set; } = [];

    [Display("Organic etv")]
    [JsonProperty("organic_etv")]
    public double? OrganicEtv { get; set; }

    [Display("Organic count")]
    [JsonProperty("organic_count")]
    public long? OrganicCount { get; set; }

    [Display("Organic is lost")]
    [JsonProperty("organic_is_lost")]
    public long? OrganicIsLost { get; set; }

    [Display("Organic is new")]
    [JsonProperty("organic_is_new")]
    public long? OrganicIsNew { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Main domain")]
    [JsonProperty("main_domain")]
    public string? MainDomain { get; set; }

    [Display("Metrics history")]
    [JsonProperty("metrics_history")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? MetricsHistory { get; set; }

    [Display("Metrics difference")]
    [JsonProperty("metrics_difference")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? MetricsDifference { get; set; }
}
