using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentParsingElement
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Fetch time")]
    [JsonProperty("fetch_time")]
    public string? FetchTime { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }

    [Display("Page content")]
    [JsonProperty("page_content")]
    public PageContentInfo? PageContent { get; set; }

    [Display("Page as markdown")]
    [JsonProperty("page_as_markdown")]
    public string? PageAsMarkdown { get; set; }
}
