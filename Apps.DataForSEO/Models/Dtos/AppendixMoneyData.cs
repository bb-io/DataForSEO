using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixMoneyData
{
    [Display("Total")]
    [JsonProperty("total")]
    public double? Total { get; set; }

    [Display("Balance")]
    [JsonProperty("balance")]
    public double? Balance { get; set; }

    [Display("Limits")]
    [JsonProperty("limits")]
    public AppendixLimitsMoneyData? Limits { get; set; }

    [Display("Statistics")]
    [JsonProperty("statistics")]
    public AppendixStatisticsDataInfo? Statistics { get; set; }
}
