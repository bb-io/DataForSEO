using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksHistoryLiveItem
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

    [Display("Crawled pages")]
    [JsonProperty("crawled_pages")]
    public long? CrawledPages { get; set; }

    [Display("Info")]
    [JsonProperty("info")]
    public TargetInfo? Info { get; set; }

    [Display("Internal links count")]
    [JsonProperty("internal_links_count")]
    public long? InternalLinksCount { get; set; }

    [Display("External links count")]
    [JsonProperty("external_links_count")]
    public long? ExternalLinksCount { get; set; }

    [Display("Broken backlinks")]
    [JsonProperty("broken_backlinks")]
    public long? BrokenBacklinks { get; set; }

    [Display("Broken pages")]
    [JsonProperty("broken_pages")]
    public long? BrokenPages { get; set; }

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

    [Display("Referring pages")]
    [JsonProperty("referring_pages")]
    public long? ReferringPages { get; set; }

    [Display("Referring pages nofollow")]
    [JsonProperty("referring_pages_nofollow")]
    public long? ReferringPagesNofollow { get; set; }

    [Display("Referring links tld")]
    [JsonProperty("referring_links_tld")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksTld { get; set; }

    [Display("Referring links types")]
    [JsonProperty("referring_links_types")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksTypes { get; set; }

    [Display("Referring links attributes")]
    [JsonProperty("referring_links_attributes")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksAttributes { get; set; }

    [Display("Referring links platform types")]
    [JsonProperty("referring_links_platform_types")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksPlatformTypes { get; set; }

    [Display("Referring links semantic locations")]
    [JsonProperty("referring_links_semantic_locations")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksSemanticLocations { get; set; }

    [Display("Referring links countries")]
    [JsonProperty("referring_links_countries")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ReferringLinksCountries { get; set; }
}
