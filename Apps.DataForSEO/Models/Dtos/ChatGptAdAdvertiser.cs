using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ChatGptAdAdvertiser
{
    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Favicon URL")]
    [JsonProperty("favicon_url")]
    public string? FaviconUrl { get; set; }
}
