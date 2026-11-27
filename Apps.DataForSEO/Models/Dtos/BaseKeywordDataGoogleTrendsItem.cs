using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseKeywordDataGoogleTrendsItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Position")]
    [JsonProperty("position")]
    public long? Position { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Keywords")]
    [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Keywords { get; set; } = [];

    [Display("Data")]
    [JsonProperty("data")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Data { get; set; }

    [Display("Averages")]
    [JsonProperty("averages", NullValueHandling = NullValueHandling.Ignore)]
    public List<double> Averages { get; set; } = [];
}
