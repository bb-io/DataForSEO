using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksDomainIntersectionLiveResultInfo
{
    [Display("Targets")]
    [JsonProperty("targets")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Targets { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BacklinksDomainIntersectionLiveItem> Items { get; set; } = [];
}
