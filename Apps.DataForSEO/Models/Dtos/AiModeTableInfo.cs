using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiModeTableInfo
{
    [Display("Table header")]
    [JsonProperty("table_header", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> TableHeader { get; set; } = [];

    [Display("Table content")]
    [JsonProperty("table_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<List<string>> TableContent { get; set; } = [];
}
