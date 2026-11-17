using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseGeminiLlmScraperElementItem
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

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Original text")]
    [JsonProperty("original_text")]
    public string? OriginalText { get; set; }

    [Display("Sources")]
    [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<SourceInfo> Sources { get; set; } = [];

    [Display("Table")]
    [JsonProperty("table")]
    public Table? Table { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<GeminiImagesElement> Items { get; set; } = [];
}
