using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SerpBingOrganicTaskGetAdvancedResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Se domain")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Check URL")]
    [JsonProperty("check_url")]
    public string? CheckUrl { get; set; }

    [Display("Datetime")]
    [JsonProperty("datetime")]
    public DateTime? Datetime { get; set; }

    [Display("Spell")]
    [JsonProperty("spell")]
    public SpellInfo? Spell { get; set; }

    [Display("Refinement chips")]
    [JsonProperty("refinement_chips")]
    public RefinementChipsInfo? RefinementChips { get; set; }

    [Display("Item types")]
    [JsonProperty("item_types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ItemTypes { get; set; } = [];

    [Display("Se results count")]
    [JsonProperty("se_results_count")]
    public long? SeResultsCount { get; set; }

    [Display("Pages count")]
    [JsonProperty("pages_count")]
    public long? PagesCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BaseBingSerpApiElementItem> Items { get; set; } = [];
}
