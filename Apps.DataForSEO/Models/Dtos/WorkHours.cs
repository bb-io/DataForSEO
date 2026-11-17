using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class WorkHours
{
    [Display("Timetable")]
    [JsonProperty("timetable")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Timetable { get; set; }

    [Display("Current status")]
    [JsonProperty("current_status")]
    public string? CurrentStatus { get; set; }
}
