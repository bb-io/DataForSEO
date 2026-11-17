using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsAmazonProductRankOverviewLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Asin")]
    [JsonProperty("asin")]
    public string? Asin { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    public AmazonMetricsBundleInfo? Metrics { get; set; }
}
