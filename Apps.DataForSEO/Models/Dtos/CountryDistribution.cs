using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class CountryDistribution
{
    [Display("Country iso code")]
    [JsonProperty("country_iso_code")]
    public string? CountryIsoCode { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Percentage")]
    [JsonProperty("percentage")]
    public double? Percentage { get; set; }
}
