using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageMicrodataInfoItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Inspection info")]
    [JsonProperty("inspection_info")]
    public MicrodataInspectionInfo? InspectionInfo { get; set; }
}
