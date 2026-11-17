using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageResourceIssueItemInfo
{
    [Display("Line")]
    [JsonProperty("line")]
    public long? Line { get; set; }

    [Display("Column")]
    [JsonProperty("column")]
    public long? Column { get; set; }

    [Display("Message")]
    [JsonProperty("message")]
    public string? Message { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }
}
