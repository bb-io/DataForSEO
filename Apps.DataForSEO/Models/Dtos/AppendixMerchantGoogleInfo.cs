using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixMerchantGoogleInfo
{
    [Display("Products")]
    [JsonProperty("products")]
    public AppendixSerpDaysRatesDataInfo? Products { get; set; }

    [Display("Sellers")]
    [JsonProperty("sellers")]
    public AppendixSellersGoogleMerchantLimitsRatesDataInfo? Sellers { get; set; }

    [Display("Product spec")]
    [JsonProperty("product_spec")]
    public AppendixSerpDaysRatesDataInfo? ProductSpec { get; set; }

    [Display("Product info")]
    [JsonProperty("product_info")]
    public AppendixSerpDaysRatesDataInfo? ProductInfo { get; set; }
}
