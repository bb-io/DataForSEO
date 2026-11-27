using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTaskKeywordsDataPriceDataInfo
{
    [Display("Priority low")]
    [JsonProperty("priority_low", NullValueHandling = NullValueHandling.Ignore)]
    public List<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityLow { get; set; } = [];

    [Display("Priority normal")]
    [JsonProperty("priority_normal", NullValueHandling = NullValueHandling.Ignore)]
    public List<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityNormal { get; set; } = [];

    [Display("Priority high")]
    [JsonProperty("priority_high", NullValueHandling = NullValueHandling.Ignore)]
    public List<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityHigh { get; set; } = [];
}
