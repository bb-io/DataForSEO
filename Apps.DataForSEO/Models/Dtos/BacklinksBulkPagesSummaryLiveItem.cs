using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkPagesSummaryLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Main domain rank")]
    [JsonProperty("main_domain_rank")]
    public long? MainDomainRank { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public long? Backlinks { get; set; }

    [Display("First seen")]
    [JsonProperty("first_seen")]
    public DateTime? FirstSeen { get; set; }

    [Display("Lost date")]
    [JsonProperty("lost_date")]
    public string? LostDate { get; set; }

    [Display("Backlinks spam score")]
    [JsonProperty("backlinks_spam_score")]
    public long? BacklinksSpamScore { get; set; }

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
