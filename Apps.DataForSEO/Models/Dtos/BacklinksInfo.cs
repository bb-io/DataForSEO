using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksInfo
{
    [Display("Referring domains")]
    [JsonProperty("referring_domains")]
    public long? ReferringDomains { get; set; }

    [Display("Referring main domains")]
    [JsonProperty("referring_main_domains")]
    public long? ReferringMainDomains { get; set; }

    [Display("Referring pages")]
    [JsonProperty("referring_pages")]
    public long? ReferringPages { get; set; }

    [Display("Dofollow")]
    [JsonProperty("dofollow")]
    public long? Dofollow { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public long? Backlinks { get; set; }

    [Display("Time update")]
    [JsonProperty("time_update")]
    public string? TimeUpdate { get; set; }
}
