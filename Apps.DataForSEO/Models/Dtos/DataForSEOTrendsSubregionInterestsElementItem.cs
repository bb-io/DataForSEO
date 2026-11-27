using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsSubregionInterestsElementItem
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

    [Display("Interests")]
    [JsonProperty("interests", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOTrendsinterestsInfo> Interests { get; set; } = [];

    [Display("Interests comparison")]
    [JsonProperty("interests_comparison")]
    public InterestsComparison? InterestsComparison { get; set; }
}
