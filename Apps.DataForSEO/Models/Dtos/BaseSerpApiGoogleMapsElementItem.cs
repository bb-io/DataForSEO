using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseSerpApiGoogleMapsElementItem
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

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("Rating distribution")]
    [JsonProperty("rating_distribution")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? RatingDistribution { get; set; }

    [Display("Original title")]
    [JsonProperty("original_title")]
    public string? OriginalTitle { get; set; }

    [Display("Contact URL")]
    [JsonProperty("contact_url")]
    public string? ContactUrl { get; set; }

    [Display("Contributor URL")]
    [JsonProperty("contributor_url")]
    public string? ContributorUrl { get; set; }

    [Display("Book online URL")]
    [JsonProperty("book_online_url")]
    public string? BookOnlineUrl { get; set; }

    [Display("Hotel rating")]
    [JsonProperty("hotel_rating")]
    public double? HotelRating { get; set; }

    [Display("Price level")]
    [JsonProperty("price_level")]
    public string? PriceLevel { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Address")]
    [JsonProperty("address")]
    public string? Address { get; set; }

    [Display("Address info")]
    [JsonProperty("address_info")]
    public AddressInfo? AddressInfo { get; set; }

    [Display("Place ID")]
    [JsonProperty("place_id")]
    public string? PlaceId { get; set; }

    [Display("Phone")]
    [JsonProperty("phone")]
    public string? Phone { get; set; }

    [Display("Main image")]
    [JsonProperty("main_image")]
    public string? MainImage { get; set; }

    [Display("Total photos")]
    [JsonProperty("total_photos")]
    public long? TotalPhotos { get; set; }

    [Display("Category")]
    [JsonProperty("category")]
    public string? Category { get; set; }

    [Display("Additional categories")]
    [JsonProperty("additional_categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> AdditionalCategories { get; set; } = [];

    [Display("Category ids")]
    [JsonProperty("category_ids", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> CategoryIds { get; set; } = [];

    [Display("Work hours")]
    [JsonProperty("work_hours")]
    public WorkHours? WorkHours { get; set; }

    [Display("Feature ID")]
    [JsonProperty("feature_id")]
    public string? FeatureId { get; set; }

    [Display("Cid")]
    [JsonProperty("cid")]
    public string? Cid { get; set; }

    [Display("Latitude")]
    [JsonProperty("latitude")]
    public double? Latitude { get; set; }

    [Display("Longitude")]
    [JsonProperty("longitude")]
    public double? Longitude { get; set; }

    [Display("Is claimed")]
    [JsonProperty("is_claimed")]
    public bool? IsClaimed { get; set; }

    [Display("Local justifications")]
    [JsonProperty("local_justifications", NullValueHandling = NullValueHandling.Ignore)]
    public List<LocalJustificationInfo> LocalJustifications { get; set; } = [];

    [Display("Is directory item")]
    [JsonProperty("is_directory_item")]
    public bool? IsDirectoryItem { get; set; }
}
