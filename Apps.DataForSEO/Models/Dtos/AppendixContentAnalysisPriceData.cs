using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixContentAnalysisPriceData
{
    [Display("Categories")]
    [JsonProperty("categories")]
    public AppendixTaskKeywordsDataPriceDataInfo? Categories { get; set; }

    [Display("Category trends")]
    [JsonProperty("category_trends")]
    public AppendixBingKeywordsDataPriceDataInfo? CategoryTrends { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Phrase trends")]
    [JsonProperty("phrase_trends")]
    public AppendixBingKeywordsDataPriceDataInfo? PhraseTrends { get; set; }

    [Display("Rating distribution")]
    [JsonProperty("rating_distribution")]
    public AppendixBingKeywordsDataPriceDataInfo? RatingDistribution { get; set; }

    [Display("Search")]
    [JsonProperty("search")]
    public AppendixBingKeywordsDataPriceDataInfo? Search { get; set; }

    [Display("Sentiment analysis")]
    [JsonProperty("sentiment_analysis")]
    public AppendixBingKeywordsDataPriceDataInfo? SentimentAnalysis { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public AppendixBingKeywordsDataPriceDataInfo? Summary { get; set; }
}
