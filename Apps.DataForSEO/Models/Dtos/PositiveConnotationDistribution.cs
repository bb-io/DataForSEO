using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PositiveConnotationDistribution
{
    [Display("Positive")]
    [JsonProperty("positive")]
    public ContentAnalysisSummaryInfo? Positive { get; set; }

    [Display("Negative")]
    [JsonProperty("negative")]
    public ContentAnalysisSummaryInfo? Negative { get; set; }

    [Display("Neutral")]
    [JsonProperty("neutral")]
    public ContentAnalysisSummaryInfo? Neutral { get; set; }
}
