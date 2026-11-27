using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AnalysisContentInfo
{
    [Display("Content type")]
    [JsonProperty("content_type")]
    public string? ContentType { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Main title")]
    [JsonProperty("main_title")]
    public string? MainTitle { get; set; }

    [Display("Previous title")]
    [JsonProperty("previous_title")]
    public string? PreviousTitle { get; set; }

    [Display("Level")]
    [JsonProperty("level")]
    public long? Level { get; set; }

    [Display("Author")]
    [JsonProperty("author")]
    public string? Author { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Snippet length")]
    [JsonProperty("snippet_length")]
    public long? SnippetLength { get; set; }

    [Display("Social metrics")]
    [JsonProperty("social_metrics", NullValueHandling = NullValueHandling.Ignore)]
    public List<SocialMetricsInfo> SocialMetrics { get; set; } = [];

    [Display("Highlighted text")]
    [JsonProperty("highlighted_text")]
    public string? HighlightedText { get; set; }

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Sentiment connotations")]
    [JsonProperty("sentiment_connotations")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? SentimentConnotations { get; set; }

    [Display("Connotation types")]
    [JsonProperty("connotation_types")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ConnotationTypes { get; set; }

    [Display("Text category")]
    [JsonProperty("text_category", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> TextCategory { get; set; } = [];

    [Display("Date published")]
    [JsonProperty("date_published")]
    public string? DatePublished { get; set; }

    [Display("Content quality score")]
    [JsonProperty("content_quality_score")]
    public long? ContentQualityScore { get; set; }

    [Display("Semantic location")]
    [JsonProperty("semantic_location")]
    public string? SemanticLocation { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public ContententRatingInfo? Rating { get; set; }

    [Display("Group date")]
    [JsonProperty("group_date")]
    public string? GroupDate { get; set; }
}
