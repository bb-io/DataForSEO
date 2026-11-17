using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class GeminiImagesElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Alt")]
    [JsonProperty("alt")]
    public string? Alt { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }
}
