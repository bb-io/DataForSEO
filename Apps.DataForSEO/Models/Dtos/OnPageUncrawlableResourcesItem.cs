using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageUncrawlableResourcesItem
{
    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Reason")]
    [JsonProperty("reason")]
    public string? Reason { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }

    [Display("Fetch time")]
    [JsonProperty("fetch_time")]
    public string? FetchTime { get; set; }

    [Display("Meta")]
    [JsonProperty("meta")]
    public UncrawlableResourcesMeta? Meta { get; set; }
}
