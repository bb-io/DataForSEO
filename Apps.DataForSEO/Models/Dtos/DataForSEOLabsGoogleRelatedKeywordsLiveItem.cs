using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleRelatedKeywordsLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Keyword data")]
    [JsonProperty("keyword_data")]
    public KeywordDataInfo? KeywordData { get; set; }

    [Display("Depth")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Related keywords")]
    [JsonProperty("related_keywords", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> RelatedKeywords { get; set; } = [];
}
