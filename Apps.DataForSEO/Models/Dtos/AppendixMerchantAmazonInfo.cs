using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixMerchantAmazonInfo
{
    [Display("Asin")]
    [JsonProperty("asin")]
    public AppendixSerpDaysRatesDataInfo? Asin { get; set; }

    [Display("Products")]
    [JsonProperty("products")]
    public AppendixSerpDaysRatesDataInfo? Products { get; set; }

    [Display("Sellers")]
    [JsonProperty("sellers")]
    public AppendixSerpDaysRatesDataInfo? Sellers { get; set; }
}
