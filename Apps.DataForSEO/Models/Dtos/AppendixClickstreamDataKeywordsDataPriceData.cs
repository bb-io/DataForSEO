using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixClickstreamDataKeywordsDataPriceData
{
    [Display("Bulk search volume")]
    [JsonProperty("bulk_search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkSearchVolume { get; set; }

    [Display("DataForSEO search volume")]
    [JsonProperty("dataforseo_search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? DataForSEOSearchVolume { get; set; }

    [Display("Global search volume")]
    [JsonProperty("global_search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? GlobalSearchVolume { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? LocationsAndLanguages { get; set; }
}
