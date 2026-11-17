using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class CrawlStatusInfo
{
    [Display("Max crawl pages")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Pages in queue")]
    [JsonProperty("pages_in_queue")]
    public long? PagesInQueue { get; set; }

    [Display("Pages crawled")]
    [JsonProperty("pages_crawled")]
    public long? PagesCrawled { get; set; }
}
