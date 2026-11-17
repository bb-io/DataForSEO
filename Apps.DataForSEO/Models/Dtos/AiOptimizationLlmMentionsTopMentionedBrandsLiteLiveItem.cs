using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationLlmMentionsTopMentionedBrandsLiteLiveItem
{
    [Display("Brand")]
    [JsonProperty("brand")]
    public string? Brand { get; set; }

    [Display("Location")]
    [JsonProperty("location")]
    public long? Location { get; set; }

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Platform")]
    [JsonProperty("platform")]
    public string? Platform { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    public AggregatedMetricsInfoTotalInfo? Metrics { get; set; }
}
