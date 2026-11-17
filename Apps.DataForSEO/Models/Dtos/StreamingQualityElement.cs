using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class StreamingQualityElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Label")]
    [JsonProperty("label")]
    public string? Label { get; set; }

    [Display("Width")]
    [JsonProperty("width")]
    public long? Width { get; set; }

    [Display("Height")]
    [JsonProperty("height")]
    public long? Height { get; set; }

    [Display("Bitrate")]
    [JsonProperty("bitrate")]
    public long? Bitrate { get; set; }

    [Display("Mime type")]
    [JsonProperty("mime_type")]
    public string? MimeType { get; set; }

    [Display("Fps")]
    [JsonProperty("fps")]
    public long? Fps { get; set; }
}
