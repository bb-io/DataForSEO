using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixSerpDataInfo
{
    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public AppendixFunctionTypeInfo? TaskGet { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Live")]
    [JsonProperty("live")]
    public AppendixFunctionTypeInfo? Live { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Tasks fixed")]
    [JsonProperty("tasks_fixed")]
    public double? TasksFixed { get; set; }

    [Display("Jobs")]
    [JsonProperty("jobs")]
    public AppendixJobsSerpLimitsRatesDataInfo? Jobs { get; set; }

    [Display("Screenshot")]
    [JsonProperty("screenshot")]
    public double? Screenshot { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Ai summary")]
    [JsonProperty("ai_summary")]
    public double? AiSummary { get; set; }

    [Display("Tasks ready queue")]
    [JsonProperty("tasks_ready_queue")]
    public double? TasksReadyQueue { get; set; }
}
