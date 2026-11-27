using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TargetInfo
{
    [Display("Server")]
    [JsonProperty("server")]
    public string? Server { get; set; }

    [Display("Cms")]
    [JsonProperty("cms")]
    public string? Cms { get; set; }

    [Display("Platform type")]
    [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> PlatformType { get; set; } = [];

    [Display("Ip address")]
    [JsonProperty("ip_address")]
    public string? IpAddress { get; set; }

    [Display("Country")]
    [JsonProperty("country")]
    public string? Country { get; set; }

    [Display("Is ip")]
    [JsonProperty("is_ip")]
    public bool? IsIp { get; set; }

    [Display("Target spam score")]
    [JsonProperty("target_spam_score")]
    public long? TargetSpamScore { get; set; }
}
