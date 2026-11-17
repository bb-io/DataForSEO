using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleHistoricalRankOverviewLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Metrics { get; set; }
}
