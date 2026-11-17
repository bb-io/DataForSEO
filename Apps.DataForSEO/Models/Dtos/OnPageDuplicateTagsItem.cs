using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageDuplicateTagsItem
{
    [Display("Accumulator")]
    [JsonProperty("accumulator")]
    public string? Accumulator { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Pages")]
    [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageHtmlResourceItem> Pages { get; set; } = [];
}
