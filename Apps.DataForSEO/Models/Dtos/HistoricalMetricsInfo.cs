using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HistoricalMetricsInfo
{
    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Etv")]
    [JsonProperty("etv")]
    public double? Etv { get; set; }

    [Display("Count")]
    [JsonProperty("count")]
    public long? Count { get; set; }
}
