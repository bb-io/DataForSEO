using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksDomainIntersectionLiveItem
{
    [Display("Domain intersection")]
    [JsonProperty("domain_intersection")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? DomainIntersection { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public IntersectionSummaryInfo? Summary { get; set; }
}
