using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsDataForSEOTrendsGraphElementItem
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

    [Display("Data")]
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOTrendsGraphDataTrendsGraphDataInfo> Data { get; set; } = [];

    [Display("Averages")]
    [JsonProperty("averages", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> Averages { get; set; } = [];
}
