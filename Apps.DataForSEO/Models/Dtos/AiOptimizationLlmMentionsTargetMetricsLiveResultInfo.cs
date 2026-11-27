using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsTargetMetricsLiveResultInfo
{
    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Aggregated metrics")]
    [JsonProperty("aggregated_metrics")]
    public LlmMentionsAggregatedMetricsInfo? AggregatedMetrics { get; set; }

    [Display("Items")]
    [JsonProperty("items")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Items { get; set; }
}
