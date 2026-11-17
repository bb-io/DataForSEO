using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SerpAiSummaryItem
{
    [Display("Summary")]
    [JsonProperty("summary")]
    public string? Summary { get; set; }
}
