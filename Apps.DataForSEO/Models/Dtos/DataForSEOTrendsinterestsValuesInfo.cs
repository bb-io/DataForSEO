using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsinterestsValuesInfo
{
    [Display("Geo ID")]
    [JsonProperty("geo_id")]
    public string? GeoId { get; set; }

    [Display("Geo name")]
    [JsonProperty("geo_name")]
    public string? GeoName { get; set; }

    [Display("Value")]
    [JsonProperty("value")]
    public long? Value { get; set; }
}
