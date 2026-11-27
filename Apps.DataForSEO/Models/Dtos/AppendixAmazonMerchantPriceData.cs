using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAmazonMerchantPriceData
{
    [Display("Asin")]
    [JsonProperty("asin")]
    public AppendixAmazonMerchantPriceDataInfo? Asin { get; set; }

    [Display("Products")]
    [JsonProperty("products")]
    public AppendixAmazonMerchantPriceDataInfo? Products { get; set; }

    [Display("Sellers")]
    [JsonProperty("sellers")]
    public AppendixAmazonMerchantPriceDataInfo? Sellers { get; set; }
}
