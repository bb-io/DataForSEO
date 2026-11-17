using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleKeywordSuggestionsLiveResultInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Seed keyword")]
    [JsonProperty("seed_keyword")]
    public string? SeedKeyword { get; set; }

    [Display("Seed keyword data")]
    [JsonProperty("seed_keyword_data")]
    public KeywordDataInfo? SeedKeywordData { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordDataInfo> Items { get; set; } = [];
}
