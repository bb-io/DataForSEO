using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixSerpPriceData
{
    [Display("Tasks fixed")]
    [JsonProperty("tasks_fixed")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksFixed { get; set; }

    [Display("Ai summary")]
    [JsonProperty("ai_summary")]
    public AppendixTaskKeywordsDataPriceDataInfo? AiSummary { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Jobs")]
    [JsonProperty("jobs")]
    public AppendixAKeywordsDataPriceDataInfo? Jobs { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Languages { get; set; }

    [Display("Live")]
    [JsonProperty("live")]
    public AppendixSerpPriceDataInfo? Live { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Screenshot")]
    [JsonProperty("screenshot")]
    public AppendixTaskKeywordsDataPriceDataInfo? Screenshot { get; set; }

    [Display("Task get")]
    [JsonProperty("task_get")]
    public AppendixSerpPriceDataInfo? TaskGet { get; set; }

    [Display("Task post")]
    [JsonProperty("task_post")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
