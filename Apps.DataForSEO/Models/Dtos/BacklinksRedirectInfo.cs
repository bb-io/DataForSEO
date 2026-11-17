using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksRedirectInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }
}
