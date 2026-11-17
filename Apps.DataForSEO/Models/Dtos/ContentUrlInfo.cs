using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentUrlInfo
{
    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Anchor text")]
    [JsonProperty("anchor_text")]
    public string? AnchorText { get; set; }
}
