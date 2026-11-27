using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AbsoluteItems
{
    [Display("Geo ID")]
    [JsonProperty("geo_id")]
    public string? GeoId { get; set; }

    [Display("Geo name")]
    [JsonProperty("geo_name")]
    public string? GeoName { get; set; }

    [Display("Values")]
    [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Values { get; set; } = [];
}
