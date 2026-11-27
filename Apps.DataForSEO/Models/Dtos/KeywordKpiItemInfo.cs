using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordKpiItemInfo
{
    [Display("Ad position")]
    [JsonProperty("ad_position")]
    public string? AdPosition { get; set; }

    [Display("Clicks")]
    [JsonProperty("clicks")]
    public long? Clicks { get; set; }

    [Display("Impressions")]
    [JsonProperty("impressions")]
    public long? Impressions { get; set; }

    [Display("Average CPC")]
    [JsonProperty("average_cpc")]
    public double? AverageCpc { get; set; }

    [Display("CTR")]
    [JsonProperty("ctr")]
    public double? Ctr { get; set; }

    [Display("Total cost")]
    [JsonProperty("total_cost")]
    public double? TotalCost { get; set; }

    [Display("Average bid")]
    [JsonProperty("average_bid")]
    public double? AverageBid { get; set; }
}
