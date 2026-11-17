using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageWaterfallItem
{
    [Display("Page URL")]
    [JsonProperty("page_url")]
    public string? PageUrl { get; set; }

    [Display("Time to interactive")]
    [JsonProperty("time_to_interactive")]
    public long? TimeToInteractive { get; set; }

    [Display("Dom complete")]
    [JsonProperty("dom_complete")]
    public long? DomComplete { get; set; }

    [Display("Connection time")]
    [JsonProperty("connection_time")]
    public long? ConnectionTime { get; set; }

    [Display("Time to secure connection")]
    [JsonProperty("time_to_secure_connection")]
    public long? TimeToSecureConnection { get; set; }

    [Display("Request sent time")]
    [JsonProperty("request_sent_time")]
    public long? RequestSentTime { get; set; }

    [Display("Waiting time")]
    [JsonProperty("waiting_time")]
    public long? WaitingTime { get; set; }

    [Display("Download time")]
    [JsonProperty("download_time")]
    public long? DownloadTime { get; set; }

    [Display("Duration time")]
    [JsonProperty("duration_time")]
    public long? DurationTime { get; set; }

    [Display("Fetch start")]
    [JsonProperty("fetch_start")]
    public long? FetchStart { get; set; }

    [Display("Fetch end")]
    [JsonProperty("fetch_end")]
    public long? FetchEnd { get; set; }

    [Display("Resources")]
    [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
    public List<WaterfallResourceInfo> Resources { get; set; } = [];
}
