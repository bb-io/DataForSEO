using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class LlmMentionsAggregatedMetricsInfo
{
    [Display("Location")]
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> Location { get; set; } = [];

    [Display("Language")]
    [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> Language { get; set; } = [];

    [Display("Platform")]
    [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> Platform { get; set; } = [];

    [Display("Sources domain")]
    [JsonProperty("sources_domain", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> SourcesDomain { get; set; } = [];

    [Display("Search results domain")]
    [JsonProperty("search_results_domain", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> SearchResultsDomain { get; set; } = [];

    [Display("Brand entities title")]
    [JsonProperty("brand_entities_title", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> BrandEntitiesTitle { get; set; } = [];

    [Display("Brand entities category")]
    [JsonProperty("brand_entities_category", NullValueHandling = NullValueHandling.Ignore)]
    public List<AggregatedMetricsItemInfo> BrandEntitiesCategory { get; set; } = [];

    [Display("Total")]
    [JsonProperty("total")]
    public AggregatedMetricsInfoTotalInfo? Total { get; set; }
}
