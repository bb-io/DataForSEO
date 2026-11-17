using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksDomainPagesLiveResultInfo
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BacklinksDomainPagesLiveItem> Items { get; set; } = [];
}
