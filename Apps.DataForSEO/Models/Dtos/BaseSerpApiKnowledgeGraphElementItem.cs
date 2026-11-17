using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiKnowledgeGraphElementItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Rectangle")]
    [JsonProperty("rectangle")]
    public AiModeRectangleInfo? Rectangle { get; set; }

    [Display("Rank group")]
    [JsonProperty("rank_group")]
    public long? RankGroup { get; set; }

    [Display("Rank absolute")]
    [JsonProperty("rank_absolute")]
    public long? RankAbsolute { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Data attrid")]
    [JsonProperty("data_attrid")]
    public string? DataAttrid { get; set; }

    [Display("Link")]
    [JsonProperty("link")]
    public LinkElement? Link { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<KnowledgeGraphListElement> Items { get; set; } = [];

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<LinkElement> Links { get; set; } = [];

    [Display("Expanded element")]
    [JsonProperty("expanded_element", NullValueHandling = NullValueHandling.Ignore)]
    public List<KnowledgeGraphExpandedElement> ExpandedElement { get; set; } = [];

    [Display("Date from")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Asynchronous ai overview")]
    [JsonProperty("asynchronous_ai_overview")]
    public bool? AsynchronousAiOverview { get; set; }

    [Display("References")]
    [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewReferenceInfo> References { get; set; } = [];
}
