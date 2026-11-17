using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageResourceLocationInfo
{
    [Display("Line")]
    [JsonProperty("line")]
    public long? Line { get; set; }

    [Display("Offset left")]
    [JsonProperty("offset_left")]
    public long? OffsetLeft { get; set; }

    [Display("Offset top")]
    [JsonProperty("offset_top")]
    public long? OffsetTop { get; set; }
}
