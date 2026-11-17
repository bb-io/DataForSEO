using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class LinkElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }
}
