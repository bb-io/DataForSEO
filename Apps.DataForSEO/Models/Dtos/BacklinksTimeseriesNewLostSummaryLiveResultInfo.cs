using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksTimeseriesNewLostSummaryLiveResultInfo
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Date from")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Group range")]
    [JsonProperty("group_range")]
    public string? GroupRange { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BacklinksTimeseriesNewLostSummaryLiveItem> Items { get; set; } = [];
}
