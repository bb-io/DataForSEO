using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsHistoricalLiveResultInfo
{
    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiOptimizationLlmMentionsHistoricalLiveItem> Items { get; set; } = [];
}
