using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageMicrodataResultInfo
{
    [Display("Crawl progress")]
    [JsonProperty("crawl_progress")]
    public string? CrawlProgress { get; set; }

    [Display("Crawl status")]
    [JsonProperty("crawl_status")]
    public CrawlStatusInfo? CrawlStatus { get; set; }

    [Display("Test summary")]
    [JsonProperty("test_summary")]
    public TestSummary? TestSummary { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageMicrodataInfoItem> Items { get; set; } = [];
}
