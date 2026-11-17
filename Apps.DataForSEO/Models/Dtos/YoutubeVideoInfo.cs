using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class YoutubeVideoInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Rank group")]
    [JsonProperty("rank_group")]
    public long? RankGroup { get; set; }

    [Display("Rank absolute")]
    [JsonProperty("rank_absolute")]
    public long? RankAbsolute { get; set; }

    [Display("Video ID")]
    [JsonProperty("video_id")]
    public string? VideoId { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Thumbnail URL")]
    [JsonProperty("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [Display("Channel ID")]
    [JsonProperty("channel_id")]
    public string? ChannelId { get; set; }

    [Display("Channel name")]
    [JsonProperty("channel_name")]
    public string? ChannelName { get; set; }

    [Display("Channel URL")]
    [JsonProperty("channel_url")]
    public string? ChannelUrl { get; set; }

    [Display("Channel logo")]
    [JsonProperty("channel_logo")]
    public string? ChannelLogo { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Views count")]
    [JsonProperty("views_count")]
    public long? ViewsCount { get; set; }

    [Display("Likes count")]
    [JsonProperty("likes_count")]
    public long? LikesCount { get; set; }

    [Display("Comments count")]
    [JsonProperty("comments_count")]
    public long? CommentsCount { get; set; }

    [Display("Channel subscribers count")]
    [JsonProperty("channel_subscribers_count")]
    public ChannelSubscribersCount? ChannelSubscribersCount { get; set; }

    [Display("Publication date")]
    [JsonProperty("publication_date")]
    public string? PublicationDate { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("Keywords")]
    [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Keywords { get; set; } = [];

    [Display("Category")]
    [JsonProperty("category")]
    public string? Category { get; set; }

    [Display("Is live")]
    [JsonProperty("is_live")]
    public bool? IsLive { get; set; }

    [Display("Is embeddable")]
    [JsonProperty("is_embeddable")]
    public bool? IsEmbeddable { get; set; }

    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public string? DurationTime { get; set; }

    [Display("Duration time seconds")]
    [JsonProperty("duration_time_seconds")]
    public long? DurationTimeSeconds { get; set; }

    [Display("Subtitles")]
    [JsonProperty("subtitles", NullValueHandling = NullValueHandling.Ignore)]
    public List<Subtitles> Subtitles { get; set; } = [];

    [Display("Streaming quality")]
    [JsonProperty("streaming_quality", NullValueHandling = NullValueHandling.Ignore)]
    public List<StreamingQualityElement> StreamingQuality { get; set; } = [];
}
