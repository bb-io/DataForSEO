using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TopStoriesElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Source")]
    [JsonProperty("source")]
    public string? Source { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Amp version")]
    [JsonProperty("amp_version")]
    public bool? AmpVersion { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Badges")]
    [JsonProperty("badges", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Badges { get; set; } = [];
}
