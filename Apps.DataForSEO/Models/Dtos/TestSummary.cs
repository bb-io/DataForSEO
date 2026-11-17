using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TestSummary
{
    [Display("Fatal")]
    [JsonProperty("fatal")]
    public long? Fatal { get; set; }

    [Display("Error")]
    [JsonProperty("error")]
    public long? Error { get; set; }

    [Display("Warning")]
    [JsonProperty("warning")]
    public long? Warning { get; set; }

    [Display("Info")]
    [JsonProperty("info")]
    public long? Info { get; set; }
}
