using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsAmazonRankedKeywordsLiveResultInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Asin")]
    [JsonProperty("asin")]
    public string? Asin { get; set; }

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
    public List<DataForSEOLabsAmazonRankedKeywordsLiveItem> Items { get; set; } = [];
}
