using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAppendixDaysRatesDataInfo
{
    [Display("User data")]
    [JsonProperty("user_data")]
    public double? UserData { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }
}
