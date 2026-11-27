using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class Autocomplete
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

    [Display("Relevance")]
    [JsonProperty("relevance")]
    public long? Relevance { get; set; }

    [Display("Suggestion")]
    [JsonProperty("suggestion")]
    public string? Suggestion { get; set; }

    [Display("Suggestion type")]
    [JsonProperty("suggestion_type")]
    public string? SuggestionType { get; set; }

    [Display("Search query URL")]
    [JsonProperty("search_query_url")]
    public string? SearchQueryUrl { get; set; }

    [Display("Thumbnail URL")]
    [JsonProperty("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [Display("Highlighted")]
    [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Highlighted { get; set; } = [];
}
