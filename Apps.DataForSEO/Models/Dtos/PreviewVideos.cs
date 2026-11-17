using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PreviewVideos
{
    [Display("Video ID")]
    [JsonProperty("video_id")]
    public string? VideoId { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public string? DurationTime { get; set; }

    [Display("Duration time seconds")]
    [JsonProperty("duration_time_seconds")]
    public long? DurationTimeSeconds { get; set; }
}
