using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AmazonMetricsBundleInfo
{
    [Display("Amazon SERP")]
    [JsonProperty("amazon_serp")]
    public AppMetricsInfo? AmazonSerp { get; set; }

    [Display("Amazon paid")]
    [JsonProperty("amazon_paid")]
    public AppMetricsInfo? AmazonPaid { get; set; }
}
