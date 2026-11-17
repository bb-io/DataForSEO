using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiYoutubeOrganicElementItem
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

    [Display("Block rank")]
    [JsonProperty("block_rank")]
    public long? BlockRank { get; set; }

    [Display("Block name")]
    [JsonProperty("block_name")]
    public string? BlockName { get; set; }

    [Display("Channel ID")]
    [JsonProperty("channel_id")]
    public string? ChannelId { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("Logo")]
    [JsonProperty("logo")]
    public string? Logo { get; set; }

    [Display("Video count")]
    [JsonProperty("video_count")]
    public long? VideoCount { get; set; }

    [Display("Is verified")]
    [JsonProperty("is_verified")]
    public bool? IsVerified { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Highlighted")]
    [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Highlighted { get; set; } = [];

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Video ID")]
    [JsonProperty("video_id")]
    public string? VideoId { get; set; }

    [Display("Thumbnail URL")]
    [JsonProperty("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [Display("Channel name")]
    [JsonProperty("channel_name")]
    public string? ChannelName { get; set; }

    [Display("Channel URL")]
    [JsonProperty("channel_url")]
    public string? ChannelUrl { get; set; }

    [Display("Channel logo")]
    [JsonProperty("channel_logo")]
    public string? ChannelLogo { get; set; }

    [Display("Badges")]
    [JsonProperty("badges", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Badges { get; set; } = [];

    [Display("Is live")]
    [JsonProperty("is_live")]
    public bool? IsLive { get; set; }

    [Display("Is shorts")]
    [JsonProperty("is_shorts")]
    public bool? IsShorts { get; set; }

    [Display("Is movie")]
    [JsonProperty("is_movie")]
    public bool? IsMovie { get; set; }

    [Display("Views count")]
    [JsonProperty("views_count")]
    public long? ViewsCount { get; set; }

    [Display("Publication date")]
    [JsonProperty("publication_date")]
    public string? PublicationDate { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public string? DurationTime { get; set; }

    [Display("Duration time seconds")]
    [JsonProperty("duration_time_seconds")]
    public long? DurationTimeSeconds { get; set; }

    [Display("Playlist ID")]
    [JsonProperty("playlist_id")]
    public string? PlaylistId { get; set; }

    [Display("Videos count")]
    [JsonProperty("videos_count")]
    public long? VideosCount { get; set; }

    [Display("Preview videos")]
    [JsonProperty("preview_videos", NullValueHandling = NullValueHandling.Ignore)]
    public List<PreviewVideos> PreviewVideos { get; set; } = [];
}
