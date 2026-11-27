using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixContentAnalysisLimitsRatesDataInfo
{
    [Display("Search")]
    [JsonProperty("search")]
    public AppendixInfo? Search { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public AppendixInfo? Summary { get; set; }

    [Display("Sentiment analysis")]
    [JsonProperty("sentiment_analysis")]
    public AppendixInfo? SentimentAnalysis { get; set; }

    [Display("Rating distribution")]
    [JsonProperty("rating_distribution")]
    public AppendixInfo? RatingDistribution { get; set; }

    [Display("Phrase trends")]
    [JsonProperty("phrase_trends")]
    public AppendixInfo? PhraseTrends { get; set; }

    [Display("Category trends")]
    [JsonProperty("category_trends")]
    public AppendixInfo? CategoryTrends { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public double? Categories { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }
}
