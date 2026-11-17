using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiModeAiOverviewInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Rank group")]
    [JsonProperty("rank_group")]
    public long? RankGroup { get; set; }

    [Display("Rank absolute")]
    [JsonProperty("rank_absolute")]
    public long? RankAbsolute { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BaseSerpApiAiModeAiOverviewElementItem> Items { get; set; } = [];

    [Display("References")]
    [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewReferenceInfo> References { get; set; } = [];

    [Display("Rectangle")]
    [JsonProperty("rectangle")]
    public AiModeRectangleInfo? Rectangle { get; set; }
}
