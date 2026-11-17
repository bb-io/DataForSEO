using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAKeywordsDataPriceDataInfo
{
    [Display("Task get")]
    [JsonProperty("task_get")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskGet { get; set; }

    [Display("Task post")]
    [JsonProperty("task_post")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskPost { get; set; }
}
