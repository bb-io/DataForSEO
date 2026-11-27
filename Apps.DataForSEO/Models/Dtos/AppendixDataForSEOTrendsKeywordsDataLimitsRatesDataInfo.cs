using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDataForSEOTrendsKeywordsDataLimitsRatesDataInfo
{
    [Display("Explore")]
    [JsonProperty("explore")]
    public AppendixInfo? Explore { get; set; }

    [Display("Subregion interests")]
    [JsonProperty("subregion_interests")]
    public AppendixInfo? SubregionInterests { get; set; }

    [Display("Demography")]
    [JsonProperty("demography")]
    public AppendixInfo? Demography { get; set; }

    [Display("Merged data")]
    [JsonProperty("merged_data")]
    public AppendixInfo? MergedData { get; set; }
}
