using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLlmResponsesAiOptimizationPriceData
{
    [Display("Live")]
    [JsonProperty("live")]
    public AppendixTaskKeywordsDataPriceDataInfo? Live { get; set; }

    [Display("Models")]
    [JsonProperty("models")]
    public AppendixTaskKeywordsDataPriceDataInfo? Models { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskGet { get; set; }

    [Display("Task post")]
    [JsonProperty("task_post")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
