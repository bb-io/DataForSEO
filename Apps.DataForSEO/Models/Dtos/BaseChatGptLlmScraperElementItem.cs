using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseChatGptLlmScraperElementItem
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

    [Display("Sources")]
    [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<SourceInfo> Sources { get; set; } = [];

    [Display("Brand entities")]
    [JsonProperty("brand_entities", NullValueHandling = NullValueHandling.Ignore)]
    public List<ChatGptBrandEntity> BrandEntities { get; set; } = [];

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Table")]
    [JsonProperty("table")]
    public Table? Table { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<GeminiImagesElement> Items { get; set; } = [];

    [Display("Is rendered")]
    [JsonProperty("is_rendered")]
    public bool? IsRendered { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Advertiser")]
    [JsonProperty("advertiser")]
    public ChatGptAdAdvertiser? Advertiser { get; set; }
}
