using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordDataInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Keyword info")]
    [JsonProperty("keyword_info")]
    public KeywordInfo? KeywordInfo { get; set; }

    [Display("Keyword info normalized with bing")]
    [JsonProperty("keyword_info_normalized_with_bing")]
    public KeywordInfoNormalizedWithInfo? KeywordInfoNormalizedWithBing { get; set; }

    [Display("Keyword info normalized with clickstream")]
    [JsonProperty("keyword_info_normalized_with_clickstream")]
    public KeywordInfoNormalizedWithInfo? KeywordInfoNormalizedWithClickstream { get; set; }

    [Display("Clickstream keyword info")]
    [JsonProperty("clickstream_keyword_info")]
    public ClickstreamKeywordInfo? ClickstreamKeywordInfo { get; set; }

    [Display("Keyword properties")]
    [JsonProperty("keyword_properties")]
    public KeywordProperties? KeywordProperties { get; set; }

    [Display("SERP info")]
    [JsonProperty("serp_info")]
    public SerpInfo? SerpInfo { get; set; }

    [Display("Avg backlinks info")]
    [JsonProperty("avg_backlinks_info")]
    public AvgBacklinksInfo? AvgBacklinksInfo { get; set; }

    [Display("Search intent info")]
    [JsonProperty("search_intent_info")]
    public SearchIntentInfo? SearchIntentInfo { get; set; }
}
