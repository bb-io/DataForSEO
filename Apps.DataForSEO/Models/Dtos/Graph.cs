using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class Graph
{
    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<GraphElement> Items { get; set; } = [];

    [Display("Previous items")]
    [JsonProperty("previous_items", NullValueHandling = NullValueHandling.Ignore)]
    public List<GraphElement> PreviousItems { get; set; } = [];
}
