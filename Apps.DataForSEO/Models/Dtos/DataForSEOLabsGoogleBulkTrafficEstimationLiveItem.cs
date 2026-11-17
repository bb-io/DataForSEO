using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleBulkTrafficEstimationLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    public BulkMetricsBundleInfo? Metrics { get; set; }
}
