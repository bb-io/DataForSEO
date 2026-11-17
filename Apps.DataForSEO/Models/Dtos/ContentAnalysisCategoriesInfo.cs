using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentAnalysisCategoriesInfo
{
    [Display("Category")]
    [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> Category { get; set; } = [];

    [Display("Count")]
    [JsonProperty("count")]
    public long? Count { get; set; }
}
