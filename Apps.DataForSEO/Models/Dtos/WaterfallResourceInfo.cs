using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class WaterfallResourceInfo
{
    [Display("Resource type")]
    [JsonProperty("resource_type")]
    public string? ResourceType { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Initiator")]
    [JsonProperty("initiator")]
    public string? Initiator { get; set; }

    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public long? DurationTime { get; set; }

    [Display("Fetch start")]
    [JsonProperty("fetch_start")]
    public long? FetchStart { get; set; }

    [Display("Fetch end")]
    [JsonProperty("fetch_end")]
    public long? FetchEnd { get; set; }

    [Display("Location")]
    [JsonProperty("location")]
    public OnPageResourceLocationInfo? Location { get; set; }

    [Display("Is render blocking")]
    [JsonProperty("is_render_blocking")]
    public bool? IsRenderBlocking { get; set; }
}
