using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentAnalysisSearchLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Main domain")]
    [JsonProperty("main_domain")]
    public string? MainDomain { get; set; }

    [Display("URL rank")]
    [JsonProperty("url_rank")]
    public long? UrlRank { get; set; }

    [Display("Spam score")]
    [JsonProperty("spam_score")]
    public long? SpamScore { get; set; }

    [Display("Domain rank")]
    [JsonProperty("domain_rank")]
    public long? DomainRank { get; set; }

    [Display("Fetch time")]
    [JsonProperty("fetch_time")]
    public string? FetchTime { get; set; }

    [Display("Country")]
    [JsonProperty("country")]
    public string? Country { get; set; }

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Score")]
    [JsonProperty("score")]
    public double? Score { get; set; }

    [Display("Page category")]
    [JsonProperty("page_category", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> PageCategory { get; set; } = [];

    [Display("Page types")]
    [JsonProperty("page_types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> PageTypes { get; set; } = [];

    [Display("Ratings")]
    [JsonProperty("ratings", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContententRatingInfo> Ratings { get; set; } = [];

    [Display("Social metrics")]
    [JsonProperty("social_metrics", NullValueHandling = NullValueHandling.Ignore)]
    public List<SocialMetricsInfo> SocialMetrics { get; set; } = [];

    [Display("Content info")]
    [JsonProperty("content_info")]
    public AnalysisContentInfo? ContentInfo { get; set; }
}
