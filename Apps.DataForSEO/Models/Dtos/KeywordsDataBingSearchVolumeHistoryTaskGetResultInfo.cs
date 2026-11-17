using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataBingSearchVolumeHistoryTaskGetResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Device")]
    [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Device { get; set; } = [];

    [Display("Period")]
    [JsonProperty("period")]
    public string? Period { get; set; }

    [Display("Searches")]
    [JsonProperty("searches")]
    public SearchVolumeHistorySearchInfo? Searches { get; set; }
}
