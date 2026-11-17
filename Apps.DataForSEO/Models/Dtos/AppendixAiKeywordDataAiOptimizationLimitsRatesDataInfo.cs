using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAiKeywordDataAiOptimizationLimitsRatesDataInfo
{
    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public double? LocationsAndLanguages { get; set; }

    [Display("Keywords search volume")]
    [JsonProperty("keywords_search_volume")]
    public AppendixInfo? KeywordsSearchVolume { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }
}
