using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DomainInfo
{
    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("Cms")]
    [JsonProperty("cms")]
    public string? Cms { get; set; }

    [Display("Ip")]
    [JsonProperty("ip")]
    public string? Ip { get; set; }

    [Display("Server")]
    [JsonProperty("server")]
    public string? Server { get; set; }

    [Display("Crawl start")]
    [JsonProperty("crawl_start")]
    public string? CrawlStart { get; set; }

    [Display("Crawl end")]
    [JsonProperty("crawl_end")]
    public string? CrawlEnd { get; set; }

    [Display("Extended crawl status")]
    [JsonProperty("extended_crawl_status")]
    public string? ExtendedCrawlStatus { get; set; }

    [Display("Ssl info")]
    [JsonProperty("ssl_info")]
    public SslInfo? SslInfo { get; set; }

    [Display("Checks")]
    [JsonProperty("checks")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Checks { get; set; }

    [Display("Total pages")]
    [JsonProperty("total_pages")]
    public long? TotalPages { get; set; }

    [Display("Total uncrawlable resources")]
    [JsonProperty("total_uncrawlable_resources")]
    public long? TotalUncrawlableResources { get; set; }

    [Display("Page not found status code")]
    [JsonProperty("page_not_found_status_code")]
    public long? PageNotFoundStatusCode { get; set; }

    [Display("Canonicalization status code")]
    [JsonProperty("canonicalization_status_code")]
    public long? CanonicalizationStatusCode { get; set; }

    [Display("Directory browsing status code")]
    [JsonProperty("directory_browsing_status_code")]
    public long? DirectoryBrowsingStatusCode { get; set; }

    [Display("Www redirect status code")]
    [JsonProperty("www_redirect_status_code")]
    public long? WwwRedirectStatusCode { get; set; }

    [Display("Main domain")]
    [JsonProperty("main_domain")]
    public string? MainDomain { get; set; }
}
