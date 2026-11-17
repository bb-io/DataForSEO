using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixLlmResponsesAiOptimizationLimitsRatesDataInfo
{
    [Display("Live")]
    [JsonProperty("live")]
    public double? Live { get; set; }

    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public double? TaskGet { get; set; }

    [Display("Models")]
    [JsonProperty("models")]
    public double? Models { get; set; }
}
