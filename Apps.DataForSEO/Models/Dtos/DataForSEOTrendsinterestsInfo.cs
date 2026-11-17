using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsinterestsInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Values")]
    [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOTrendsinterestsValuesInfo> Values { get; set; } = [];
}
