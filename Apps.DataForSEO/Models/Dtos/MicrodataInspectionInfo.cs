using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class MicrodataInspectionInfo
{
    [Display("Types")]
    [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Types { get; set; } = [];

    [Display("Fields")]
    [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
    public List<MicrodataFieldsInfo> Fields { get; set; } = [];
}
