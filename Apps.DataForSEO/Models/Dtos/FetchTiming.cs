using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class FetchTiming
{
    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public long? DurationTime { get; set; }

    [Display("Fetch start")]
    [JsonProperty("fetch_start")]
    public long? FetchStart { get; set; }

    [Display("Fetch end")]
    [JsonProperty("fetch_end")]
    public long? FetchEnd { get; set; }
}
