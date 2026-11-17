using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageNonIndexableItem
{
    [Display("Reason")]
    [JsonProperty("reason")]
    public string? Reason { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }
}
