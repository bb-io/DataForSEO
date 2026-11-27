using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HistoricalMetricsBundleInfo
{
    [Display("Organic")]
    [JsonProperty("organic", NullValueHandling = NullValueHandling.Ignore)]
    public List<HistoricalMetricsInfo> Organic { get; set; } = [];

    [Display("Paid")]
    [JsonProperty("paid", NullValueHandling = NullValueHandling.Ignore)]
    public List<HistoricalMetricsInfo> Paid { get; set; } = [];

    [Display("Local pack")]
    [JsonProperty("local_pack", NullValueHandling = NullValueHandling.Ignore)]
    public List<HistoricalMetricsInfo> LocalPack { get; set; } = [];

    [Display("Featured snippet")]
    [JsonProperty("featured_snippet", NullValueHandling = NullValueHandling.Ignore)]
    public List<HistoricalMetricsInfo> FeaturedSnippet { get; set; } = [];
}
