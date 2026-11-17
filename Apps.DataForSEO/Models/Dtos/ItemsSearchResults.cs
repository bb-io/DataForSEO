using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ItemsSearchResults
{
    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Breadcrumb")]
    [JsonProperty("breadcrumb")]
    public string? Breadcrumb { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Publication date")]
    [JsonProperty("publication_date")]
    public string? PublicationDate { get; set; }
}
