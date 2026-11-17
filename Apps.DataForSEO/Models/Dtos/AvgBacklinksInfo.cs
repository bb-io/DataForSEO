using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AvgBacklinksInfo
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public double? Backlinks { get; set; }

    [Display("Dofollow")]
    [JsonProperty("dofollow")]
    public double? Dofollow { get; set; }

    [Display("Referring pages")]
    [JsonProperty("referring_pages")]
    public double? ReferringPages { get; set; }

    [Display("Referring domains")]
    [JsonProperty("referring_domains")]
    public double? ReferringDomains { get; set; }

    [Display("Referring main domains")]
    [JsonProperty("referring_main_domains")]
    public double? ReferringMainDomains { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public double? Rank { get; set; }

    [Display("Main domain rank")]
    [JsonProperty("main_domain_rank")]
    public double? MainDomainRank { get; set; }

    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }
}
