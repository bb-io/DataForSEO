using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ChannelSubscribersCount
{
    [Display("Displayed count")]
    [JsonProperty("displayed_count")]
    public string? DisplayedCount { get; set; }

    [Display("Count")]
    [JsonProperty("count")]
    public long? Count { get; set; }
}
