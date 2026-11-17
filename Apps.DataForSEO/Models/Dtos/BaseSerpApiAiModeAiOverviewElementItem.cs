using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiAiModeAiOverviewElementItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeLinkElementInfo> Links { get; set; } = [];

    [Display("Images")]
    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeImagesElementInfo> Images { get; set; } = [];

    [Display("References")]
    [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewReferenceInfo> References { get; set; } = [];

    [Display("Components")]
    [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewExpandedComponentInfo> Components { get; set; } = [];

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

    [Display("Source")]
    [JsonProperty("source")]
    public string? Source { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("Table")]
    [JsonProperty("table")]
    public AiModeTableInfo? Table { get; set; }

    [Display("Code type")]
    [JsonProperty("code_type")]
    public string? CodeType { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewShoppingElementInfo> Items { get; set; } = [];
}
