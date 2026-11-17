using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDataForSEOTrendsKeywordsDataPriceData
{
    [Display("Demography")]
    [JsonProperty("demography")]
    public AppendixBingKeywordsDataPriceDataInfo? Demography { get; set; }

    [Display("Explore")]
    [JsonProperty("explore")]
    public AppendixBingKeywordsDataPriceDataInfo? Explore { get; set; }

    [Display("Merged data")]
    [JsonProperty("merged_data")]
    public AppendixBingKeywordsDataPriceDataInfo? MergedData { get; set; }

    [Display("Subregion interests")]
    [JsonProperty("subregion_interests")]
    public AppendixBingKeywordsDataPriceDataInfo? SubregionInterests { get; set; }
}
