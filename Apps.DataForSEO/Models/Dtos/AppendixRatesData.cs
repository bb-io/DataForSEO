using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixRatesData
{
    [Display("Limits")]
    [JsonProperty("limits")]
    public AppendixLimitsRatesData? Limits { get; set; }

    [Display("Statistics")]
    [JsonProperty("statistics")]
    public AppendixStatisticsDataInfo? Statistics { get; set; }
}
