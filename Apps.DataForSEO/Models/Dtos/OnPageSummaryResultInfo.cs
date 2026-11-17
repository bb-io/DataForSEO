using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageSummaryResultInfo
{
    [Display("Crawl progress")]
    [JsonProperty("crawl_progress")]
    public string? CrawlProgress { get; set; }

    [Display("Crawl status")]
    [JsonProperty("crawl_status")]
    public CrawlStatusInfo? CrawlStatus { get; set; }

    [Display("Crawl gateway address")]
    [JsonProperty("crawl_gateway_address")]
    public string? CrawlGatewayAddress { get; set; }

    [Display("Crawl stop reason")]
    [JsonProperty("crawl_stop_reason")]
    public string? CrawlStopReason { get; set; }

    [Display("Domain info")]
    [JsonProperty("domain_info")]
    public DomainInfo? DomainInfo { get; set; }

    [Display("Page metrics")]
    [JsonProperty("page_metrics")]
    public PageMetrics? PageMetrics { get; set; }
}
