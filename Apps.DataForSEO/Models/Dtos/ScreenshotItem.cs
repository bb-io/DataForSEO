using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ScreenshotItem
{
    [Display("Image")]
    [JsonProperty("image")]
    public string? Image { get; set; }
}
