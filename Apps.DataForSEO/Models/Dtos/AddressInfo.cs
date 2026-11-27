using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AddressInfo
{
    [Display("Borough")]
    [JsonProperty("borough")]
    public string? Borough { get; set; }

    [Display("Address")]
    [JsonProperty("address")]
    public string? Address { get; set; }

    [Display("City")]
    [JsonProperty("city")]
    public string? City { get; set; }

    [Display("Zip")]
    [JsonProperty("zip")]
    public string? Zip { get; set; }

    [Display("Region")]
    [JsonProperty("region")]
    public string? Region { get; set; }

    [Display("Country code")]
    [JsonProperty("country_code")]
    public string? CountryCode { get; set; }
}
