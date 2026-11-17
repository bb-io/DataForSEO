using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsTargetMetricsLiteLiveResultInfo
{
    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Aggregated metrics")]
    [JsonProperty("aggregated_metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? AggregatedMetrics { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiOptimizationLlmMentionsTargetMetricsLiteLiveItem> Items { get; set; } = [];
}
