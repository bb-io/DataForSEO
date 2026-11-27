using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixStatisticsDataInfo
{
    [Display("Day")]
    [JsonProperty("day")]
    public AppendixStatisticsRatesDataInfo? Day { get; set; }

    [Display("Minute")]
    [JsonProperty("minute")]
    public AppendixStatisticsRatesDataInfo? Minute { get; set; }
}
