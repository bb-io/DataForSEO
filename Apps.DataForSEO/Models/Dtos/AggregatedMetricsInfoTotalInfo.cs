using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AggregatedMetricsInfoTotalInfo
{
    [Display("Mentions")]
    [JsonProperty("mentions")]
    public long? Mentions { get; set; }

    [Display("Ai search volume")]
    [JsonProperty("ai_search_volume")]
    public long? AiSearchVolume { get; set; }
}
