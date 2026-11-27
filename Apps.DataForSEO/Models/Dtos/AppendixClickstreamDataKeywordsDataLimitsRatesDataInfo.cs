using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixClickstreamDataKeywordsDataLimitsRatesDataInfo
{
    [Display("DataForSEO search volume")]
    [JsonProperty("dataforseo_search_volume")]
    public AppendixInfo? DataForSEOSearchVolume { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public double? LocationsAndLanguages { get; set; }

    [Display("Bulk search volume")]
    [JsonProperty("bulk_search_volume")]
    public AppendixInfo? BulkSearchVolume { get; set; }

    [Display("Global search volume")]
    [JsonProperty("global_search_volume")]
    public AppendixInfo? GlobalSearchVolume { get; set; }
}
