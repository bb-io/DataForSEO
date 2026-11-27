using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAppendixDataInfo
{
    [Display("User data")]
    [JsonProperty("user_data")]
    public double? UserData { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Status")]
    [JsonProperty("status")]
    public double? Status { get; set; }

    [Display("Test")]
    [JsonProperty("test")]
    public double? Test { get; set; }
}
