using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AboutThisResultElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Source")]
    [JsonProperty("source")]
    public string? Source { get; set; }

    [Display("Source info")]
    [JsonProperty("source_info")]
    public string? SourceInfo { get; set; }

    [Display("Source URL")]
    [JsonProperty("source_url")]
    public string? SourceUrl { get; set; }

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Location")]
    [JsonProperty("location")]
    public string? Location { get; set; }

    [Display("Search terms")]
    [JsonProperty("search_terms", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> SearchTerms { get; set; } = [];

    [Display("Related terms")]
    [JsonProperty("related_terms", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> RelatedTerms { get; set; } = [];
}
