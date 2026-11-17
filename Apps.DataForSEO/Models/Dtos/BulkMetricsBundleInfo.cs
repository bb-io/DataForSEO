using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BulkMetricsBundleInfo
{
    [Display("Organic")]
    [JsonProperty("organic")]
    public BulkMetricsInfo? Organic { get; set; }

    [Display("Paid")]
    [JsonProperty("paid")]
    public BulkMetricsInfo? Paid { get; set; }

    [Display("Local pack")]
    [JsonProperty("local_pack")]
    public BulkMetricsInfo? LocalPack { get; set; }

    [Display("Featured snippet")]
    [JsonProperty("featured_snippet")]
    public BulkMetricsInfo? FeaturedSnippet { get; set; }
}
