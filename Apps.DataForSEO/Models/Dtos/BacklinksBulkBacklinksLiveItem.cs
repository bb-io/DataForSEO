using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkBacklinksLiveItem
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public long? Backlinks { get; set; }
}
