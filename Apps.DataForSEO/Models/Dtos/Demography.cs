using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class Demography
{
    [Display("Age")]
    [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOTrendsDataInfo> Age { get; set; } = [];

    [Display("Gender")]
    [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
    public List<DataForSEOTrendsDataInfo> Gender { get; set; } = [];
}
