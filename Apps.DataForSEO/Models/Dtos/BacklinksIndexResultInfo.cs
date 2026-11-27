using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksIndexResultInfo
{
    [Display("Total backlinks")]
    [JsonProperty("total_backlinks")]
    public long? TotalBacklinks { get; set; }

    [Display("Total pages")]
    [JsonProperty("total_pages")]
    public long? TotalPages { get; set; }

    [Display("Index history")]
    [JsonProperty("index_history", NullValueHandling = NullValueHandling.Ignore)]
    public List<IndexHistory> IndexHistory { get; set; } = [];
}
