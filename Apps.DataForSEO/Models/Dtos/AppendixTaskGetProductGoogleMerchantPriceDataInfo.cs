using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTaskGetProductGoogleMerchantPriceDataInfo
{
    [Display("Advanced")]
    [JsonProperty("advanced")]
    public AppendixTaskKeywordsDataPriceDataInfo? Advanced { get; set; }

    [Display("HTML")]
    [JsonProperty("html")]
    public AppendixTaskKeywordsDataPriceDataInfo? Html { get; set; }
}
