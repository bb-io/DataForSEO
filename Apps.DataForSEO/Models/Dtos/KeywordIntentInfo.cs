using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordIntentInfo
{
    [Display("Label")]
    [JsonProperty("label")]
    public string? Label { get; set; }

    [Display("Probability")]
    [JsonProperty("probability")]
    public double? Probability { get; set; }
}
