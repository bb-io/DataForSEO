using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAiKeywordDataAiOptimizationPriceData
{
    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Keywords search volume")]
    [JsonProperty("keywords_search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsSearchVolume { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? LocationsAndLanguages { get; set; }
}
