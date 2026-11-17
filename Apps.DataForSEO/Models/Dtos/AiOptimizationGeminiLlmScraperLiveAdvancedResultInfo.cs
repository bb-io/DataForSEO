using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationGeminiLlmScraperLiveAdvancedResultInfo
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

    [Display("Datetime")]
    [JsonProperty("datetime")]
    public DateTime? Datetime { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("Sources")]
    [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<SourceInfo> Sources { get; set; } = [];

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
    public List<BaseGeminiLlmScraperElementItem> Items { get; set; } = [];
}
