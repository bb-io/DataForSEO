using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageKeywordDensityItem
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Frequency")]
    [JsonProperty("frequency")]
    public long? Frequency { get; set; }

    [Display("Density")]
    [JsonProperty("density")]
    public double? Density { get; set; }
}
