using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class FaqBoxElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<LinkElement> Links { get; set; } = [];
}
