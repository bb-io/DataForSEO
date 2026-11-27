using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class Table
{
    [Display("Table element")]
    [JsonProperty("table_element")]
    public string? TableElement { get; set; }

    [Display("Table header")]
    [JsonProperty("table_header", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> TableHeader { get; set; } = [];

    [Display("Table content")]
    [JsonProperty("table_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<List<string>> TableContent { get; set; } = [];
}
