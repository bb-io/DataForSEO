using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageInstantPagesResultInfo
{
    [Display("Crawl progress")]
    [JsonProperty("crawl_progress")]
    public string? CrawlProgress { get; set; }

    [Display("Crawl status")]
    [JsonProperty("crawl_status")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? CrawlStatus { get; set; }

    [Display("Crawl gateway address")]
    [JsonProperty("crawl_gateway_address")]
    public string? CrawlGatewayAddress { get; set; }

    [Display("Items count")]
    [JsonProperty("items_count")]
    public long? ItemsCount { get; set; }

    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<BaseOnPageResourceItem> Items { get; set; } = [];
}
