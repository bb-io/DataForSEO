using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DuplicatePageInfo
{
    [Display("Similarity")]
    [JsonProperty("similarity")]
    public long? Similarity { get; set; }

    [Display("Page")]
    [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageHtmlResourceItem> Page { get; set; } = [];
}
