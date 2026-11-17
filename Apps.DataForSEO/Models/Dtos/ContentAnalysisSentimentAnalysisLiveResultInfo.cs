using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentAnalysisSentimentAnalysisLiveResultInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Positive connotation distribution")]
    [JsonProperty("positive_connotation_distribution")]
    public PositiveConnotationDistribution? PositiveConnotationDistribution { get; set; }

    [Display("Sentiment connotation distribution")]
    [JsonProperty("sentiment_connotation_distribution")]
    public SentimentConnotationDistribution? SentimentConnotationDistribution { get; set; }
}
