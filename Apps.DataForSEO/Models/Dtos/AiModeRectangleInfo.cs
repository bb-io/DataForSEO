using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiModeRectangleInfo
{
    [Display("X")]
    [JsonProperty("x")]
    public double? X { get; set; }

    [Display("Y")]
    [JsonProperty("y")]
    public double? Y { get; set; }

    [Display("Width")]
    [JsonProperty("width")]
    public double? Width { get; set; }

    [Display("Height")]
    [JsonProperty("height")]
    public double? Height { get; set; }
}
