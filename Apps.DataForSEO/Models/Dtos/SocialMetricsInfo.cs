using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SocialMetricsInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Like count")]
    [JsonProperty("like_count")]
    public long? LikeCount { get; set; }
}
