using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationChatGptLlmScraperLiveAdvancedResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Model")]
    [JsonProperty("model")]
    public string? Model { get; set; }

    [Display("Check URL")]
    [JsonProperty("check_url")]
    public string? CheckUrl { get; set; }

    [Display("Datetime")]
    [JsonProperty("datetime")]
    public DateTime? Datetime { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Search results")]
    [JsonProperty("search_results", NullValueHandling = NullValueHandling.Ignore)]
    public List<ChatgptSearchResult> SearchResults { get; set; } = [];

    [Display("Sources")]
    [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<SourceInfo> Sources { get; set; } = [];

    [Display("Fan out queries")]
    [JsonProperty("fan_out_queries", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> FanOutQueries { get; set; } = [];

    [Display("Brand entities")]
    [JsonProperty("brand_entities", NullValueHandling = NullValueHandling.Ignore)]
    public List<ChatGptBrandEntity> BrandEntities { get; set; } = [];

    [Display("Se results count")]
    [JsonProperty("se_results_count")]
    public long? SeResultsCount { get; set; }

    [Display("Item types")]
    [JsonProperty("item_types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ItemTypes { get; set; } = [];

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BaseChatGptLlmScraperElementItem> Items { get; set; } = [];
}
