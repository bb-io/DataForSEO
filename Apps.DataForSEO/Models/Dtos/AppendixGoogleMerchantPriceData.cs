using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixGoogleMerchantPriceData
{
    [Display("Product info")]
    [JsonProperty("product_info")]
    public AppendixPriceDataInfo? ProductInfo { get; set; }

    [Display("Product spec")]
    [JsonProperty("product_spec")]
    public AppendixProductGoogleMerchantPriceDataInfo? ProductSpec { get; set; }

    [Display("Products")]
    [JsonProperty("products")]
    public AppendixProductGoogleMerchantPriceDataInfo? Products { get; set; }

    [Display("Sellers")]
    [JsonProperty("sellers")]
    public AppendixSellersGoogleMerchantPriceData? Sellers { get; set; }
}
