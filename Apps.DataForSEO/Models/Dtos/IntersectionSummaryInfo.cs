using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class IntersectionSummaryInfo
{
    [Display("Intersections count")]
    [JsonProperty("intersections_count")]
    public long? IntersectionsCount { get; set; }
}
