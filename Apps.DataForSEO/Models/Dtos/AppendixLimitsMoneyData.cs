using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLimitsMoneyData
{
    [Display("Day")]
    [JsonProperty("day")]
    public AppendixDataInfo? Day { get; set; }

    [Display("Minute")]
    [JsonProperty("minute")]
    public AppendixDataInfo? Minute { get; set; }
}
