using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleCategoriesForDomainLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Categories")]
    [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<long> Categories { get; set; } = [];

    [Display("Metrics")]
    [JsonProperty("metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Metrics { get; set; }
}
