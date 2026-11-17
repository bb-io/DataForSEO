using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PageSectionContentInfo
{
    [Display("Primary content")]
    [JsonProperty("primary_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<SectionContentItemInfo> PrimaryContent { get; set; } = [];

    [Display("Secondary content")]
    [JsonProperty("secondary_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<SectionContentItemInfo> SecondaryContent { get; set; } = [];

    [Display("Table content")]
    [JsonProperty("table_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<TableContentInfo> TableContent { get; set; } = [];
}
