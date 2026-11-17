using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkNewLostBacklinksLiveItem
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("New backlinks")]
    [JsonProperty("new_backlinks")]
    public long? NewBacklinks { get; set; }

    [Display("Lost backlinks")]
    [JsonProperty("lost_backlinks")]
    public long? LostBacklinks { get; set; }
}
