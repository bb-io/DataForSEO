using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBingKeywordsDataPriceDataInfo
{
    [Display("Live")]
    [JsonProperty("live")]
    public AppendixTaskKeywordsDataPriceDataInfo? Live { get; set; }
}
