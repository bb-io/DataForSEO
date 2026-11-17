using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksDomainPagesLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Main domain")]
    [JsonProperty("main_domain")]
    public string? MainDomain { get; set; }

    [Display("Domain")]
    [JsonProperty("domain")]
    public string? Domain { get; set; }

    [Display("Tld")]
    [JsonProperty("tld")]
    public string? Tld { get; set; }

    [Display("Page")]
    [JsonProperty("page")]
    public string? Page { get; set; }

    [Display("Ip")]
    [JsonProperty("ip")]
    public string? Ip { get; set; }

    [Display("First visited")]
    [JsonProperty("first_visited")]
    public string? FirstVisited { get; set; }

    [Display("Prev visited")]
    [JsonProperty("prev_visited")]
    public string? PrevVisited { get; set; }

    [Display("Fetch time")]
    [JsonProperty("fetch_time")]
    public string? FetchTime { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }

    [Display("Location")]
    [JsonProperty("location")]
    public string? Location { get; set; }

    [Display("Size")]
    [JsonProperty("size")]
    public long? Size { get; set; }

    [Display("Encoded size")]
    [JsonProperty("encoded_size")]
    public long? EncodedSize { get; set; }

    [Display("Content encoding")]
    [JsonProperty("content_encoding")]
    public string? ContentEncoding { get; set; }

    [Display("Media type")]
    [JsonProperty("media_type")]
    public string? MediaType { get; set; }

    [Display("Server")]
    [JsonProperty("server")]
    public string? Server { get; set; }

    [Display("Meta")]
    [JsonProperty("meta")]
    public BacklinksPageMeta? Meta { get; set; }

    [Display("Page summary")]
    [JsonProperty("page_summary")]
    public PageSummary? PageSummary { get; set; }
}
