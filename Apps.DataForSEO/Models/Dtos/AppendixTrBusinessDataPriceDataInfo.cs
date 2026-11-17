using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTrBusinessDataPriceDataInfo
{
    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixLlmResponsesAiOptimizationPriceData? Reviews { get; set; }

    [Display("Search")]
    [JsonProperty("search")]
    public AppendixLlmResponsesAiOptimizationPriceData? Search { get; set; }
}
