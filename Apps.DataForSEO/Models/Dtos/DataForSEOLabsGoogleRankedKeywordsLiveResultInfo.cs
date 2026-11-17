using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleRankedKeywordsLiveResultInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

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

    [Display("Metrics")]
    [JsonProperty("metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Metrics { get; set; }

    [Display("Metrics absolute")]
    [JsonProperty("metrics_absolute")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? MetricsAbsolute { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOLabsGoogleRankedKeywordsLiveItem> Items { get; set; } = [];
}
