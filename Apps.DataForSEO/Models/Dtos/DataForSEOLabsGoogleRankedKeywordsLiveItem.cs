using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleRankedKeywordsLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Keyword data")]
    [JsonProperty("keyword_data")]
    public KeywordDataInfo? KeywordData { get; set; }

    [Display("Ranked SERP element")]
    [JsonProperty("ranked_serp_element")]
    public RankedSerpElement? RankedSerpElement { get; set; }
}
