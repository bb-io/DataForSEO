using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataClickstreamDataDataForSEOSearchVolumeLiveResultInfo
{
    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Use clickstream")]
    [JsonProperty("use_clickstream")]
    public bool? UseClickstream { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordsDataClickstreamDataSearchVolumeLiveItem> Items { get; set; } = [];
}
