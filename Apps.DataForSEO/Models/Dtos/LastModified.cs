using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class LastModified
{
    [Display("Header")]
    [JsonProperty("header")]
    public string? Header { get; set; }

    [Display("Sitemap")]
    [JsonProperty("sitemap")]
    public string? Sitemap { get; set; }

    [Display("Meta tag")]
    [JsonProperty("meta_tag")]
    public string? MetaTag { get; set; }
}
