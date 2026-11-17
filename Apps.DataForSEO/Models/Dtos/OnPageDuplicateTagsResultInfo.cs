using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageDuplicateTagsResultInfo
{
    [Display("Crawl progress")]
    [JsonProperty("crawl_progress")]
    public string? CrawlProgress { get; set; }

    [Display("Crawl status")]
    [JsonProperty("crawl_status")]
    public CrawlStatusInfo? CrawlStatus { get; set; }

    [Display("Total pages count")]
    [JsonProperty("total_pages_count")]
    public long? TotalPagesCount { get; set; }

    [Display("Pages count")]
    [JsonProperty("pages_count")]
    public long? PagesCount { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageDuplicateTagsItem> Items { get; set; } = [];
}
