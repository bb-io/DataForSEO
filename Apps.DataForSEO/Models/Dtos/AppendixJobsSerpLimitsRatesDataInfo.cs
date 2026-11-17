using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixJobsSerpLimitsRatesDataInfo
{
    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }
}
