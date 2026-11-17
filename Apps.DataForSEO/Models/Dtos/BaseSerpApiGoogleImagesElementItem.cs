using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiGoogleImagesElementItem
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

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<SerpApiCarouselElement> Items { get; set; } = [];

    [Display("Rectangle")]
    [JsonProperty("rectangle")]
    public AiModeRectangleInfo? Rectangle { get; set; }

    [Display("Subtitle")]
    [JsonProperty("subtitle")]
    public string? Subtitle { get; set; }

    [Display("Alt")]
    [JsonProperty("alt")]
    public string? Alt { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Source URL")]
    [JsonProperty("source_url")]
    public string? SourceUrl { get; set; }

    [Display("Encoded URL")]
    [JsonProperty("encoded_url")]
    public string? EncodedUrl { get; set; }
}
