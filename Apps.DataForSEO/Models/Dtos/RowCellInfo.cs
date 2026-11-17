using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RowCellInfo
{
    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("URLS")]
    [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContentUrlInfo> Urls { get; set; } = [];

    [Display("Is header")]
    [JsonProperty("is_header")]
    public bool? IsHeader { get; set; }
}
