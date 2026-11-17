using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsSearchMentionsLiveItem
{
    [Display("Platform")]
    [JsonProperty("platform")]
    public string? Platform { get; set; }

    [Display("Model name")]
    [JsonProperty("model_name")]
    public string? ModelName { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Question")]
    [JsonProperty("question")]
    public string? Question { get; set; }

    [Display("Answer")]
    [JsonProperty("answer")]
    public string? Answer { get; set; }

    [Display("Sources")]
    [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<Sources> Sources { get; set; } = [];

    [Display("Search results")]
    [JsonProperty("search_results", NullValueHandling = NullValueHandling.Ignore)]
    public List<ItemsSearchResults> SearchResults { get; set; } = [];

    [Display("Ai search volume")]
    [JsonProperty("ai_search_volume")]
    public long? AiSearchVolume { get; set; }

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];

    [Display("First response at")]
    [JsonProperty("first_response_at")]
    public string? FirstResponseAt { get; set; }

    [Display("Last response at")]
    [JsonProperty("last_response_at")]
    public string? LastResponseAt { get; set; }

    [Display("Brand entities")]
    [JsonProperty("brand_entities", NullValueHandling = NullValueHandling.Ignore)]
    public List<BrandEntities> BrandEntities { get; set; } = [];

    [Display("Fan out queries")]
    [JsonProperty("fan_out_queries", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> FanOutQueries { get; set; } = [];

    [Display("Is web search based")]
    [JsonProperty("is_web_search_based")]
    public bool? IsWebSearchBased { get; set; }
}
