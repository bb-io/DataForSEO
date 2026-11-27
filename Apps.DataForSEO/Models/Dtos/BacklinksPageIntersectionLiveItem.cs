using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksPageIntersectionLiveItem
{
    [Display("Page intersection")]
    [JsonProperty("page_intersection")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? PageIntersection { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public IntersectionSummaryInfo? Summary { get; set; }
}
