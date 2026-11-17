using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksTimeseriesSummaryLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public long? Backlinks { get; set; }

    [Display("Backlinks nofollow")]
    [JsonProperty("backlinks_nofollow")]
    public long? BacklinksNofollow { get; set; }

    [Display("Referring pages")]
    [JsonProperty("referring_pages")]
    public long? ReferringPages { get; set; }

    [Display("Referring pages nofollow")]
    [JsonProperty("referring_pages_nofollow")]
    public long? ReferringPagesNofollow { get; set; }

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

    [Display("Referring ips")]
    [JsonProperty("referring_ips")]
    public long? ReferringIps { get; set; }

    [Display("Referring subnets")]
    [JsonProperty("referring_subnets")]
    public long? ReferringSubnets { get; set; }
}
