using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTaskGetPriceDataInfo
{
    [Display("Advanced")]
    [JsonProperty("advanced")]
    public AppendixTaskKeywordsDataPriceDataInfo? Advanced { get; set; }
}
