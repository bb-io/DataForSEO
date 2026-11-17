using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBacklinksLiveResultInfo
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Mode")]
    [JsonProperty("mode")]
    public string? Mode { get; set; }

    [Display("Custom mode")]
    [JsonProperty("custom_mode")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? CustomMode { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BacklinksBacklinksLiveItem> Items { get; set; } = [];
}
