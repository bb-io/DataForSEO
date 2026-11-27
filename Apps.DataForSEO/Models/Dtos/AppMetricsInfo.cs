using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppMetricsInfo
{
    [Display("Pos 1")]
    [JsonProperty("pos_1")]
    public long? Pos1 { get; set; }

    [Display("Pos 2 3")]
    [JsonProperty("pos_2_3")]
    public long? Pos23 { get; set; }

    [Display("Pos 4 10")]
    [JsonProperty("pos_4_10")]
    public long? Pos410 { get; set; }

    [Display("Pos 11 100")]
    [JsonProperty("pos_11_100")]
    public long? Pos11100 { get; set; }

    [Display("Count")]
    [JsonProperty("count")]
    public long? Count { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }
}
