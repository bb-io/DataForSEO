using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiModeAiOverviewExpandedComponentInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Images")]
    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeImagesElementInfo> Images { get; set; } = [];

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeLinkElementInfo> Links { get; set; } = [];

    [Display("References")]
    [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewReferenceInfo> References { get; set; } = [];
}
