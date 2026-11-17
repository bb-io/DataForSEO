using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleHistoricalKeywordDataLiveItem
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

    [Display("History")]
    [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
    public List<History> History { get; set; } = [];
}
