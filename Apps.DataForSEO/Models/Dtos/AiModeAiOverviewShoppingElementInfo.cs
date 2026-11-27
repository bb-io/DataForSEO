using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiModeAiOverviewShoppingElementInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Product ID")]
    [JsonProperty("product_id")]
    public string? ProductId { get; set; }

    [Display("Data docid")]
    [JsonProperty("data_docid")]
    public string? DataDocid { get; set; }

    [Display("Gid")]
    [JsonProperty("gid")]
    public string? Gid { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Rating")]
    [JsonProperty("rating")]
    public RatingInfo? Rating { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public PriceInfo? Price { get; set; }

    [Display("Seller")]
    [JsonProperty("seller")]
    public string? Seller { get; set; }

    [Display("Snippet")]
    [JsonProperty("snippet")]
    public string? Snippet { get; set; }

    [Display("Marketplace")]
    [JsonProperty("marketplace")]
    public string? Marketplace { get; set; }

    [Display("Marketplace URL")]
    [JsonProperty("marketplace_url")]
    public string? MarketplaceUrl { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }
}
