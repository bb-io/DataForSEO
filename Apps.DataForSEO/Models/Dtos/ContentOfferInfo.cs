using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentOfferInfo
{
    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public double? Price { get; set; }

    [Display("Price currency")]
    [JsonProperty("price_currency")]
    public string? PriceCurrency { get; set; }

    [Display("Price valid until")]
    [JsonProperty("price_valid_until")]
    public string? PriceValidUntil { get; set; }
}
