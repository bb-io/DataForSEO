using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DemographyComparisonInfo
{
    [Display("Age")]
    [JsonProperty("age")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Age { get; set; }

    [Display("Gender")]
    [JsonProperty("gender")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Gender { get; set; }
}
