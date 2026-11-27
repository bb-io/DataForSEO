using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SentimentConnotationDistribution
{
    [Display("Anger")]
    [JsonProperty("anger")]
    public ContentAnalysisSummaryInfo? Anger { get; set; }

    [Display("Happiness")]
    [JsonProperty("happiness")]
    public ContentAnalysisSummaryInfo? Happiness { get; set; }

    [Display("Love")]
    [JsonProperty("love")]
    public ContentAnalysisSummaryInfo? Love { get; set; }

    [Display("Sadness")]
    [JsonProperty("sadness")]
    public ContentAnalysisSummaryInfo? Sadness { get; set; }

    [Display("Share")]
    [JsonProperty("share")]
    public ContentAnalysisSummaryInfo? Share { get; set; }

    [Display("Fun")]
    [JsonProperty("fun")]
    public ContentAnalysisSummaryInfo? Fun { get; set; }
}
