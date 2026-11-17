using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAppendixPriceData
{
    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("User data")]
    [JsonProperty("user_data")]
    public AppendixTaskKeywordsDataPriceDataInfo? UserData { get; set; }
}
