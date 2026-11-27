using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PriceInfo
{
    [Display("Current")]
    [JsonProperty("current")]
    public double? Current { get; set; }

    [Display("Regular")]
    [JsonProperty("regular")]
    public double? Regular { get; set; }

    [Display("Max value")]
    [JsonProperty("max_value")]
    public double? MaxValue { get; set; }

    [Display("Currency")]
    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [Display("Is price range")]
    [JsonProperty("is_price_range")]
    public bool? IsPriceRange { get; set; }

    [Display("Displayed price")]
    [JsonProperty("displayed_price")]
    public string? DisplayedPrice { get; set; }
}
