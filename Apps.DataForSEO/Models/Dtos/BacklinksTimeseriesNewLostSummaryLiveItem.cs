using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksTimeseriesNewLostSummaryLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("New backlinks")]
    [JsonProperty("new_backlinks")]
    public long? NewBacklinks { get; set; }

    [Display("Lost backlinks")]
    [JsonProperty("lost_backlinks")]
    public long? LostBacklinks { get; set; }

    [Display("New referring domains")]
    [JsonProperty("new_referring_domains")]
    public long? NewReferringDomains { get; set; }

    [Display("Lost referring domains")]
    [JsonProperty("lost_referring_domains")]
    public long? LostReferringDomains { get; set; }

    [Display("New referring main domains")]
    [JsonProperty("new_referring_main_domains")]
    public long? NewReferringMainDomains { get; set; }

    [Display("Lost referring main domains")]
    [JsonProperty("lost_referring_main_domains")]
    public long? LostReferringMainDomains { get; set; }
}
