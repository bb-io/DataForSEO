using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOTrendsGraphDataTrendsGraphDataInfo
{
    [Display("Date from")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Timestamp")]
    [JsonProperty("timestamp")]
    public long? Timestamp { get; set; }

    [Display("Values")]
    [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> Values { get; set; } = [];
}
