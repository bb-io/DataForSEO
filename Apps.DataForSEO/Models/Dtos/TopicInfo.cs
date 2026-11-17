using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TopicInfo
{
    [Display("H title")]
    [JsonProperty("h_title")]
    public string? HTitle { get; set; }

    [Display("Main title")]
    [JsonProperty("main_title")]
    public string? MainTitle { get; set; }

    [Display("Author")]
    [JsonProperty("author")]
    public string? Author { get; set; }

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Level")]
    [JsonProperty("level")]
    public long? Level { get; set; }

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
