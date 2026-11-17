using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLimitsRatesData
{
    [Display("Day")]
    [JsonProperty("day")]
    public AppendixDayLimitsRatesData? Day { get; set; }

    [Display("Minute")]
    [JsonProperty("minute")]
    public AppendixDataInfo? Minute { get; set; }
}
