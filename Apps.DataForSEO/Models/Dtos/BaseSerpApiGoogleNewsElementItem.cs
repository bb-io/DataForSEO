using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiGoogleNewsElementItem
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

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Rectangle")]
    [JsonProperty("rectangle")]
    public AiModeRectangleInfo? Rectangle { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Time published")]
    [JsonProperty("time_published")]
    public string? TimePublished { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<TopStoriesElement> Items { get; set; } = [];
}
