using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseBingSerpApiElementItem
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

    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Rectangle")]
    [JsonProperty("rectangle")]
    public AiModeRectangleInfo? Rectangle { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Breadcrumb")]
    [JsonProperty("breadcrumb")]
    public string? Breadcrumb { get; set; }

    [Display("Cache URL")]
    [JsonProperty("cache_url")]
    public string? CacheUrl { get; set; }

    [Display("Related search URL")]
    [JsonProperty("related_search_url")]
    public string? RelatedSearchUrl { get; set; }

    [Display("Website name")]
    [JsonProperty("website_name")]
    public string? WebsiteName { get; set; }

    [Display("Is image")]
    [JsonProperty("is_image")]
    public bool? IsImage { get; set; }

    [Display("Is video")]
    [JsonProperty("is_video")]
    public bool? IsVideo { get; set; }

    [Display("Is featured snippet")]
    [JsonProperty("is_featured_snippet")]
    public bool? IsFeaturedSnippet { get; set; }

    [Display("Is malicious")]
    [JsonProperty("is_malicious")]
    public bool? IsMalicious { get; set; }

    [Display("Is web story")]
    [JsonProperty("is_web_story")]
    public bool? IsWebStory { get; set; }

    [Display("Checks")]
    [JsonProperty("checks", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Checks { get; set; } = [];

    [Display("Pre snippet")]
    [JsonProperty("pre_snippet")]
    public string? PreSnippet { get; set; }

    [Display("Extended snippet")]
    [JsonProperty("extended_snippet")]
    public string? ExtendedSnippet { get; set; }

    [Display("Images")]
    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeImagesElementInfo> Images { get; set; } = [];

    [Display("Amp version")]
    [JsonProperty("amp_version")]
    public bool? AmpVersion { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public PriceInfo? Price { get; set; }

    [Display("Highlighted")]
    [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Highlighted { get; set; } = [];

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<LinkElement> Links { get; set; } = [];

    [Display("Faq")]
    [JsonProperty("faq")]
    public FaqBox? Faq { get; set; }

    [Display("Extended people also search")]
    [JsonProperty("extended_people_also_search", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ExtendedPeopleAlsoSearch { get; set; } = [];

    [Display("About this result")]
    [JsonProperty("about_this_result")]
    public AboutThisResultElement? AboutThisResult { get; set; }

    [Display("Related result")]
    [JsonProperty("related_result", NullValueHandling = NullValueHandling.Ignore)]
    public List<RelatedResult> RelatedResult { get; set; } = [];

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public string? Timestamp { get; set; }

    [Display("Extra")]
    [JsonProperty("extra")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Extra { get; set; }

    [Display("Description rows")]
    [JsonProperty("description_rows", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> DescriptionRows { get; set; } = [];

    [Display("Featured title")]
    [JsonProperty("featured_title")]
    public string? FeaturedTitle { get; set; }

    [Display("Table")]
    [JsonProperty("table")]
    public Table? Table { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Items { get; set; } = [];

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("References")]
    [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiModeAiOverviewReferenceInfo> References { get; set; } = [];

    [Display("Related image searches")]
    [JsonProperty("related_image_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<RelatedImageSearchesElement> RelatedImageSearches { get; set; } = [];

    [Display("Text")]
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Text { get; set; } = [];

    [Display("Phone")]
    [JsonProperty("phone")]
    public string? Phone { get; set; }

    [Display("Booking URL")]
    [JsonProperty("booking_url")]
    public string? BookingUrl { get; set; }

    [Display("Is paid")]
    [JsonProperty("is_paid")]
    public bool? IsPaid { get; set; }

    [Display("Cid")]
    [JsonProperty("cid")]
    public string? Cid { get; set; }

    [Display("Is claimed")]
    [JsonProperty("is_claimed")]
    public bool? IsClaimed { get; set; }

    [Display("Date from")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }
}
