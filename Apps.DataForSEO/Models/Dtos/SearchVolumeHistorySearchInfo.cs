using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SearchVolumeHistorySearchInfo
{
    [Display("Desktop")]
    [JsonProperty("desktop", NullValueHandling = NullValueHandling.Ignore)]
    public List<SearchVolumeHistoryItemInfo> Desktop { get; set; } = [];

    [Display("Non smartphones")]
    [JsonProperty("non_smartphones", NullValueHandling = NullValueHandling.Ignore)]
    public List<SearchVolumeHistoryItemInfo> NonSmartphones { get; set; } = [];

    [Display("Mobile")]
    [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
    public List<SearchVolumeHistoryItemInfo> Mobile { get; set; } = [];

    [Display("Tablet")]
    [JsonProperty("tablet", NullValueHandling = NullValueHandling.Ignore)]
    public List<SearchVolumeHistoryItemInfo> Tablet { get; set; } = [];
}
