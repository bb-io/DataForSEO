using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleRelevantPagesLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Page address")]
    [JsonProperty("page_address")]
    public string? PageAddress { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Metrics { get; set; }
}
