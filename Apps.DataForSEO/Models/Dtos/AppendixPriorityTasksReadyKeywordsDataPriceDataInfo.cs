using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixPriorityTasksReadyKeywordsDataPriceDataInfo
{
    [Display("Cost type")]
    [JsonProperty("cost_type")]
    public string? CostType { get; set; }

    [Display("Cost")]
    [JsonProperty("cost")]
    public double? Cost { get; set; }
}
