using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordKpi
{
    [Display("Desktop")]
    [JsonProperty("desktop", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordKpiItemInfo> Desktop { get; set; } = [];

    [Display("Mobile")]
    [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordKpiItemInfo> Mobile { get; set; } = [];

    [Display("Tablet")]
    [JsonProperty("tablet", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordKpiItemInfo> Tablet { get; set; } = [];
}
