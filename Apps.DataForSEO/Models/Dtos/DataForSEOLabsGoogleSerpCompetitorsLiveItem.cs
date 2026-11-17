using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleSerpCompetitorsLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Avg position")]
    [JsonProperty("avg_position")]
    public double? AvgPosition { get; set; }

    [Display("Median position")]
    [JsonProperty("median_position")]
    public double? MedianPosition { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public double? Rating { get; set; }

    [Display("Etv")]
    [JsonProperty("etv")]
    public double? Etv { get; set; }

    [Display("Keywords count")]
    [JsonProperty("keywords_count")]
    public long? KeywordsCount { get; set; }

    [Display("Visibility")]
    [JsonProperty("visibility")]
    public double? Visibility { get; set; }

    [Display("Relevant SERP items")]
    [JsonProperty("relevant_serp_items")]
    public long? RelevantSerpItems { get; set; }

    [Display("Keywords positions")]
    [JsonProperty("keywords_positions")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? KeywordsPositions { get; set; }
}
