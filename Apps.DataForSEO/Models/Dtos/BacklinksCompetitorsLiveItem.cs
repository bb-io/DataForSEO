using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksCompetitorsLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Intersections")]
    [JsonProperty("intersections")]
    public long? Intersections { get; set; }
}
