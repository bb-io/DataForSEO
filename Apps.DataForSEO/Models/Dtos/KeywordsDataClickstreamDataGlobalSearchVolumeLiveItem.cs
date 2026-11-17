using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataClickstreamDataGlobalSearchVolumeLiveItem
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Country distribution")]
    [JsonProperty("country_distribution", NullValueHandling = NullValueHandling.Ignore)]
    public List<CountryDistribution> CountryDistribution { get; set; } = [];
}
