using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkReferringDomainsLiveItem
{
    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Referring domains")]
    [JsonProperty("referring_domains")]
    public long? ReferringDomains { get; set; }

    [Display("Referring domains nofollow")]
    [JsonProperty("referring_domains_nofollow")]
    public long? ReferringDomainsNofollow { get; set; }

    [Display("Referring main domains")]
    [JsonProperty("referring_main_domains")]
    public long? ReferringMainDomains { get; set; }

    [Display("Referring main domains nofollow")]
    [JsonProperty("referring_main_domains_nofollow")]
    public long? ReferringMainDomainsNofollow { get; set; }
}
