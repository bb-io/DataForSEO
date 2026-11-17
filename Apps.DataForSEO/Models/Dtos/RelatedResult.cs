using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RelatedResult
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Cache URL")]
    [JsonProperty("cache_url")]
    public string? CacheUrl { get; set; }

    [Display("Related search URL")]
    [JsonProperty("related_search_url")]
    public string? RelatedSearchUrl { get; set; }

    [Display("Breadcrumb")]
    [JsonProperty("breadcrumb")]
    public string? Breadcrumb { get; set; }

    [Display("Website name")]
    [JsonProperty("website_name")]
    public string? WebsiteName { get; set; }

    [Display("Is image")]
    [JsonProperty("is_image")]
    public bool? IsImage { get; set; }

    [Display("Is video")]
    [JsonProperty("is_video")]
    public bool? IsVideo { get; set; }

    [Display("Checks")]
    [JsonProperty("checks", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Checks { get; set; } = [];

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Pre snippet")]
    [JsonProperty("pre_snippet")]
    public string? PreSnippet { get; set; }

    [Display("Extended snippet")]
    [JsonProperty("extended_snippet")]
    public string? ExtendedSnippet { get; set; }

    [Display("Images")]
    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeImagesElementInfo> Images { get; set; } = [];

    [Display("Amp version")]
    [JsonProperty("amp_version")]
    public bool? AmpVersion { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public PriceInfo? Price { get; set; }

    [Display("Highlighted")]
    [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Highlighted { get; set; } = [];

    [Display("About this result")]
    [JsonProperty("about_this_result")]
    public AboutThisResultElement? AboutThisResult { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }
}
