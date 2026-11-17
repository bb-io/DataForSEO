using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBacklinksLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Domain from")]
    [JsonProperty("domain_from")]
    public string? DomainFrom { get; set; }

    [Display("URL from")]
    [JsonProperty("url_from")]
    public string? UrlFrom { get; set; }

    [Display("URL from https")]
    [JsonProperty("url_from_https")]
    public bool? UrlFromHttps { get; set; }

    [Display("Domain to")]
    [JsonProperty("domain_to")]
    public string? DomainTo { get; set; }

    [Display("URL to")]
    [JsonProperty("url_to")]
    public string? UrlTo { get; set; }

    [Display("URL to https")]
    [JsonProperty("url_to_https")]
    public bool? UrlToHttps { get; set; }

    [Display("Tld from")]
    [JsonProperty("tld_from")]
    public string? TldFrom { get; set; }

    [Display("Is new")]
    [JsonProperty("is_new")]
    public bool? IsNew { get; set; }

    [Display("Is lost")]
    [JsonProperty("is_lost")]
    public bool? IsLost { get; set; }

    [Display("Backlink spam score")]
    [JsonProperty("backlink_spam_score")]
    public long? BacklinkSpamScore { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Page from rank")]
    [JsonProperty("page_from_rank")]
    public long? PageFromRank { get; set; }

    [Display("Domain from rank")]
    [JsonProperty("domain_from_rank")]
    public long? DomainFromRank { get; set; }

    [Display("Domain from platform type")]
    [JsonProperty("domain_from_platform_type", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> DomainFromPlatformType { get; set; } = [];

    [Display("Domain from is ip")]
    [JsonProperty("domain_from_is_ip")]
    public bool? DomainFromIsIp { get; set; }

    [Display("Domain from ip")]
    [JsonProperty("domain_from_ip")]
    public string? DomainFromIp { get; set; }

    [Display("Domain from country")]
    [JsonProperty("domain_from_country")]
    public string? DomainFromCountry { get; set; }

    [Display("Page from external links")]
    [JsonProperty("page_from_external_links")]
    public long? PageFromExternalLinks { get; set; }

    [Display("Page from internal links")]
    [JsonProperty("page_from_internal_links")]
    public long? PageFromInternalLinks { get; set; }

    [Display("Page from size")]
    [JsonProperty("page_from_size")]
    public long? PageFromSize { get; set; }

    [Display("Page from encoding")]
    [JsonProperty("page_from_encoding")]
    public string? PageFromEncoding { get; set; }

    [Display("Page from language")]
    [JsonProperty("page_from_language")]
    public string? PageFromLanguage { get; set; }

    [Display("Page from title")]
    [JsonProperty("page_from_title")]
    public string? PageFromTitle { get; set; }

    [Display("Page from status code")]
    [JsonProperty("page_from_status_code")]
    public long? PageFromStatusCode { get; set; }

    [Display("First seen")]
    [JsonProperty("first_seen")]
    public DateTime? FirstSeen { get; set; }

    [Display("Prev seen")]
    [JsonProperty("prev_seen")]
    public string? PrevSeen { get; set; }

    [Display("Last seen")]
    [JsonProperty("last_seen")]
    public DateTime? LastSeen { get; set; }

    [Display("Item type")]
    [JsonProperty("item_type")]
    public string? ItemType { get; set; }

    [Display("Attributes")]
    [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Attributes { get; set; } = [];

    [Display("Dofollow")]
    [JsonProperty("dofollow")]
    public bool? Dofollow { get; set; }

    [Display("Original")]
    [JsonProperty("original")]
    public bool? Original { get; set; }

    [Display("Alt")]
    [JsonProperty("alt")]
    public string? Alt { get; set; }

    [Display("Image URL")]
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }

    [Display("Anchor")]
    [JsonProperty("anchor")]
    public string? Anchor { get; set; }

    [Display("Text pre")]
    [JsonProperty("text_pre")]
    public string? TextPre { get; set; }

    [Display("Text post")]
    [JsonProperty("text_post")]
    public string? TextPost { get; set; }

    [Display("Semantic location")]
    [JsonProperty("semantic_location")]
    public string? SemanticLocation { get; set; }

    [Display("Links count")]
    [JsonProperty("links_count")]
    public long? LinksCount { get; set; }

    [Display("Group count")]
    [JsonProperty("group_count")]
    public long? GroupCount { get; set; }

    [Display("Is broken")]
    [JsonProperty("is_broken")]
    public bool? IsBroken { get; set; }

    [Display("URL to status code")]
    [JsonProperty("url_to_status_code")]
    public long? UrlToStatusCode { get; set; }

    [Display("URL to spam score")]
    [JsonProperty("url_to_spam_score")]
    public long? UrlToSpamScore { get; set; }

    [Display("URL to redirect target")]
    [JsonProperty("url_to_redirect_target")]
    public string? UrlToRedirectTarget { get; set; }

    [Display("Ranked keywords info")]
    [JsonProperty("ranked_keywords_info")]
    public RankedKeywordsInfo? RankedKeywordsInfo { get; set; }

    [Display("Is indirect link")]
    [JsonProperty("is_indirect_link")]
    public bool? IsIndirectLink { get; set; }

    [Display("Indirect link path")]
    [JsonProperty("indirect_link_path", NullValueHandling = NullValueHandling.Ignore)]
    public List<BacklinksRedirectInfo> IndirectLinkPath { get; set; } = [];
}
