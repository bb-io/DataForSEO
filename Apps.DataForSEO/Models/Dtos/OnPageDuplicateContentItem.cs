using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageDuplicateContentItem
{
    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Pages")]
    [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
    public List<DuplicatePageInfo> Pages { get; set; } = [];
}
