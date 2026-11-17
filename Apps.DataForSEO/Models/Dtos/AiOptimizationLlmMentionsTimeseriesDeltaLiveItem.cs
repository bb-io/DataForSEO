using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsTimeseriesDeltaLiveItem
{
    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Delta mentions")]
    [JsonProperty("delta_mentions")]
    public long? DeltaMentions { get; set; }

    [Display("Delta ai search volume")]
    [JsonProperty("delta_ai_search_volume")]
    public long? DeltaAiSearchVolume { get; set; }
}
