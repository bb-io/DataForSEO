using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixSerpPriceDataInfo
{
    [Display("HTML")]
    [JsonProperty("html")]
    public AppendixTaskKeywordsDataPriceDataInfo? Html { get; set; }

    [Display("Regular")]
    [JsonProperty("regular")]
    public AppendixTaskKeywordsDataPriceDataInfo? Regular { get; set; }

    [Display("Advanced")]
    [JsonProperty("advanced")]
    public AppendixTaskKeywordsDataPriceDataInfo? Advanced { get; set; }
}
