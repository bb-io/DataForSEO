using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HunspellMisspelledInfo
{
    [Display("Word")]
    [JsonProperty("word")]
    public string? Word { get; set; }
}
