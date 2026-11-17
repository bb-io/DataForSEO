using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentAnalysisRatingDistributionLiveResultInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Min")]
    [JsonProperty("min")]
    public double? Min { get; set; }

    [Display("Max")]
    [JsonProperty("max")]
    public double? Max { get; set; }

    [Display("Metrics")]
    [JsonProperty("metrics")]
    public ContentAnalysisSummaryInfo? Metrics { get; set; }
}
