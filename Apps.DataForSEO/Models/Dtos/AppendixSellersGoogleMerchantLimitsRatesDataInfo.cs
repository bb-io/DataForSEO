using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixSellersGoogleMerchantLimitsRatesDataInfo
{
    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public AppendixFunctionTypeInfo? TaskGet { get; set; }

    [Display("Ad URL")]
    [JsonProperty("ad_url")]
    public double? AdUrl { get; set; }
}
