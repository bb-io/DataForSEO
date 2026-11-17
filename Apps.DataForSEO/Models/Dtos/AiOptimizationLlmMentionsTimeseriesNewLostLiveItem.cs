using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsTimeseriesNewLostLiveItem
{
    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("New mentions")]
    [JsonProperty("new_mentions")]
    public long? NewMentions { get; set; }

    [Display("Lost mentions")]
    [JsonProperty("lost_mentions")]
    public long? LostMentions { get; set; }

    [Display("New ai search volume")]
    [JsonProperty("new_ai_search_volume")]
    public long? NewAiSearchVolume { get; set; }

    [Display("Lost ai search volume")]
    [JsonProperty("lost_ai_search_volume")]
    public long? LostAiSearchVolume { get; set; }
}
