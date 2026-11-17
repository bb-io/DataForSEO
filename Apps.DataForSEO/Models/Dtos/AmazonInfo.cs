using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AmazonInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

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

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Asin")]
    [JsonProperty("asin")]
    public string? Asin { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Price from")]
    [JsonProperty("price_from")]
    public double? PriceFrom { get; set; }

    [Display("Price to")]
    [JsonProperty("price_to")]
    public double? PriceTo { get; set; }

    [Display("Currency")]
    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [Display("Special offers")]
    [JsonProperty("special_offers", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> SpecialOffers { get; set; } = [];

    [Display("Is best seller")]
    [JsonProperty("is_best_seller")]
    public bool? IsBestSeller { get; set; }

    [Display("Is amazon choice")]
    [JsonProperty("is_amazon_choice")]
    public bool? IsAmazonChoice { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("Delivery info")]
    [JsonProperty("delivery_info")]
    public AmazonDeliveryInfo? DeliveryInfo { get; set; }

    [Display("Bought past month")]
    [JsonProperty("bought_past_month")]
    public long? BoughtPastMonth { get; set; }
}
