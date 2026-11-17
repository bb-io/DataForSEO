using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AmazonRankedSerpElement
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("SERP item")]
    [JsonProperty("serp_item")]
    public AmazonInfo? SerpItem { get; set; }

    [Display("Check URL")]
    [JsonProperty("check_url")]
    public string? CheckUrl { get; set; }

    [Display("SERP item types")]
    [JsonProperty("serp_item_types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> SerpItemTypes { get; set; } = [];

    [Display("Se results count")]
    [JsonProperty("se_results_count")]
    public long? SeResultsCount { get; set; }

    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }

    [Display("Previous updated time")]
    [JsonProperty("previous_updated_time")]
    public string? PreviousUpdatedTime { get; set; }
}
