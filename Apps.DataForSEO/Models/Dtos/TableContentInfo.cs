using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TableContentInfo
{
    [Display("Header")]
    [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
    public List<TableContentItemInfo> Header { get; set; } = [];

    [Display("Body")]
    [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
    public List<TableContentItemInfo> Body { get; set; } = [];

    [Display("Footer")]
    [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
    public List<TableContentItemInfo> Footer { get; set; } = [];
}
