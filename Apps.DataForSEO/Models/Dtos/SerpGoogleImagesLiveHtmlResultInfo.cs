using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SerpGoogleImagesLiveHtmlResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Se domain")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Datetime")]
    [JsonProperty("datetime")]
    public DateTime? Datetime { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<HtmlItemInfo> Items { get; set; } = [];
}
