using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPagePageScreenshotResultInfo
{
    [Display("Crawl progress")]
    [JsonProperty("crawl_progress")]
    public string? CrawlProgress { get; set; }

    [Display("Error message")]
    [JsonProperty("error_message")]
    public string? ErrorMessage { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<ScreenshotItem> Items { get; set; } = [];
}
