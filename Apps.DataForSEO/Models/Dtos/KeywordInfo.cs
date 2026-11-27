using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }

    [Display("Competition")]
    [JsonProperty("competition")]
    public double? Competition { get; set; }

    [Display("Competition level")]
    [JsonProperty("competition_level")]
    public string? CompetitionLevel { get; set; }

    [Display("CPC")]
    [JsonProperty("cpc")]
    public double? Cpc { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Low top of page bid")]
    [JsonProperty("low_top_of_page_bid")]
    public double? LowTopOfPageBid { get; set; }

    [Display("High top of page bid")]
    [JsonProperty("high_top_of_page_bid")]
    public double? HighTopOfPageBid { get; set; }

    [Display("Categories")]
    [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> Categories { get; set; } = [];

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];

    [Display("Search volume trend")]
    [JsonProperty("search_volume_trend")]
    public SearchVolumeTrend? SearchVolumeTrend { get; set; }
}
