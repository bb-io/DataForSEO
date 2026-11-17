using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkNewLostReferringDomainsLiveItem
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

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
