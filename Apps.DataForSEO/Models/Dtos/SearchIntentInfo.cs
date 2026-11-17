using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SearchIntentInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Main intent")]
    [JsonProperty("main_intent")]
    public string? MainIntent { get; set; }

    [Display("Foreign intent")]
    [JsonProperty("foreign_intent", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ForeignIntent { get; set; } = [];

    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }
}
