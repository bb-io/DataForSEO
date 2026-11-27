using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTrBusinessDataDayLimitsRatesDataInfo
{
    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixInfo? Reviews { get; set; }

    [Display("Search")]
    [JsonProperty("search")]
    public AppendixInfo? Search { get; set; }
}
