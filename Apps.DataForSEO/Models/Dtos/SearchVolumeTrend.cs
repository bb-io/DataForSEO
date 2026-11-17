using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SearchVolumeTrend
{
    [Display("Monthly")]
    [JsonProperty("monthly")]
    public long? Monthly { get; set; }

    [Display("Quarterly")]
    [JsonProperty("quarterly")]
    public long? Quarterly { get; set; }

    [Display("Yearly")]
    [JsonProperty("yearly")]
    public long? Yearly { get; set; }
}
