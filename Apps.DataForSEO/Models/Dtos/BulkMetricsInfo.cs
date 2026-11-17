using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BulkMetricsInfo
{
    [Display("Etv")]
    [JsonProperty("etv")]
    public double? Etv { get; set; }

    [Display("Count")]
    [JsonProperty("count")]
    public long? Count { get; set; }
}
