using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseDataForSEOLabsApiElementItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Rank group")]
    [JsonProperty("rank_group")]
    public long? RankGroup { get; set; }

    [Display("Rank absolute")]
    [JsonProperty("rank_absolute")]
    public long? RankAbsolute { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public string? Position { get; set; }

    [Display("Xpath")]
    [JsonProperty("xpath")]
    public string? Xpath { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Breadcrumb")]
    [JsonProperty("breadcrumb")]
    public string? Breadcrumb { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Checks")]
    [JsonProperty("checks", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Checks { get; set; } = [];

    [Display("Highlighted")]
    [JsonProperty("highlighted", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Highlighted { get; set; } = [];

    [Display("Extra")]
    [JsonProperty("extra")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Extra { get; set; }

    [Display("Description rows")]
    [JsonProperty("description_rows", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> DescriptionRows { get; set; } = [];

    [Display("Links")]
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public List<AdLinkElement> Links { get; set; } = [];

    [Display("Main domain")]
    [JsonProperty("main_domain")]
    public string? MainDomain { get; set; }

    [Display("Relative URL")]
    [JsonProperty("relative_url")]
    public string? RelativeUrl { get; set; }

    [Display("Etv")]
    [JsonProperty("etv")]
    public double? Etv { get; set; }

    [Display("Estimated paid traffic cost")]
    [JsonProperty("estimated_paid_traffic_cost")]
    public double? EstimatedPaidTrafficCost { get; set; }

    [Display("Clickstream etv")]
    [JsonProperty("clickstream_etv")]
    public double? ClickstreamEtv { get; set; }

    [Display("Rank changes")]
    [JsonProperty("rank_changes")]
    public RankChanges? RankChanges { get; set; }

    [Display("Backlinks info")]
    [JsonProperty("backlinks_info")]
    public BacklinksInfo? BacklinksInfo { get; set; }

    [Display("Rank info")]
    [JsonProperty("rank_info")]
    public RankInfo? RankInfo { get; set; }

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

    [Display("Pre snippet")]
    [JsonProperty("pre_snippet")]
    public string? PreSnippet { get; set; }

    [Display("Extended snippet")]
    [JsonProperty("extended_snippet")]
    public string? ExtendedSnippet { get; set; }

    [Display("Amp version")]
    [JsonProperty("amp_version")]
    public bool? AmpVersion { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("About this result")]
    [JsonProperty("about_this_result")]
    public AboutThisResultElement? AboutThisResult { get; set; }

    [Display("Phone")]
    [JsonProperty("phone")]
    public string? Phone { get; set; }

    [Display("Is paid")]
    [JsonProperty("is_paid")]
    public bool? IsPaid { get; set; }

    [Display("Featured title")]
    [JsonProperty("featured_title")]
    public string? FeaturedTitle { get; set; }

    [Display("Table")]
    [JsonProperty("table")]
    public Table? Table { get; set; }

    [Display("Text")]
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Text { get; set; } = [];

    [Display("Items")]
    [JsonProperty("items")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Items { get; set; }

    [Display("Reviews count")]
    [JsonProperty("reviews_count")]
    public long? ReviewsCount { get; set; }

    [Display("Place ID")]
    [JsonProperty("place_id")]
    public string? PlaceId { get; set; }

    [Display("Feature")]
    [JsonProperty("feature")]
    public string? Feature { get; set; }

    [Display("Cid")]
    [JsonProperty("cid")]
    public string? Cid { get; set; }

    [Display("Posts ID")]
    [JsonProperty("posts_id")]
    public string? PostsId { get; set; }

    [Display("Related image searches")]
    [JsonProperty("related_image_searches")]
    public RelatedImageSearchesElement? RelatedImageSearches { get; set; }

    [Display("Sub title")]
    [JsonProperty("sub_title")]
    public string? SubTitle { get; set; }

    [Display("Card ID")]
    [JsonProperty("card_id")]
    public string? CardId { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Logo URL")]
    [JsonProperty("logo_url")]
    public string? LogoUrl { get; set; }

    [Display("Date from")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Source")]
    [JsonProperty("source")]
    public string? Source { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public PriceInfo? Price { get; set; }

    [Display("Graph")]
    [JsonProperty("graph")]
    public Graph? Graph { get; set; }

    [Display("Hotel identifier")]
    [JsonProperty("hotel_identifier")]
    public string? HotelIdentifier { get; set; }

    [Display("Result")]
    [JsonProperty("result")]
    public string? Result { get; set; }

    [Display("Related searches")]
    [JsonProperty("related_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> RelatedSearches { get; set; } = [];

    [Display("Categories")]
    [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Categories { get; set; } = [];
}
