using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixFunctionTypeInfo
{
    [Display("Regular")]
    [JsonProperty("regular")]
    public double? Regular { get; set; }

    [Display("Advanced")]
    [JsonProperty("advanced")]
    public double? Advanced { get; set; }

    [Display("HTML")]
    [JsonProperty("html")]
    public double? Html { get; set; }
}
