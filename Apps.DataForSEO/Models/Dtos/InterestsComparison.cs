using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class InterestsComparison
{
    [Display("Items")]
    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<AbsoluteItems> Items { get; set; } = [];

    [Display("Absolute items")]
    [JsonProperty("absolute_items", NullValueHandling = NullValueHandling.Ignore)]
    public List<AbsoluteItems> AbsoluteItems { get; set; } = [];
}
