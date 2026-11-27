using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixInfo
{
    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public double? TaskGet { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Live")]
    [JsonProperty("live")]
    public double? Live { get; set; }
}
