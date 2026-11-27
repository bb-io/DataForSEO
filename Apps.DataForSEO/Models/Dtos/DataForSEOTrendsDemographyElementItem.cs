using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsDemographyElementItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public long? Position { get; set; }

    [Display("Keywords")]
    [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Keywords { get; set; } = [];

    [Display("Demography")]
    [JsonProperty("demography")]
    public Demography? Demography { get; set; }

    [Display("Demography comparison")]
    [JsonProperty("demography_comparison")]
    public DemographyComparisonInfo? DemographyComparison { get; set; }
}
