using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsHistoricalLiveItem
{
    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    public AggregatedMetricsInfoTotalInfo? Metrics { get; set; }
}
