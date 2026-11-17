using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixGoogleBusinessDataPriceData
{
    [Display("Extended reviews")]
    [JsonProperty("extended_reviews")]
    public AppendixAKeywordsDataPriceDataInfo? ExtendedReviews { get; set; }

    [Display("Hotel info")]
    [JsonProperty("hotel_info")]
    public AppendixAmazonMerchantPriceDataInfo? HotelInfo { get; set; }

    [Display("Hotel searches")]
    [JsonProperty("hotel_searches")]
    public AppendixLlmResponsesAiOptimizationPriceData? HotelSearches { get; set; }

    [Display("My business info")]
    [JsonProperty("my_business_info")]
    public AppendixLlmResponsesAiOptimizationPriceData? MyBusinessInfo { get; set; }

    [Display("My business updates")]
    [JsonProperty("my_business_updates")]
    public AppendixLlmResponsesAiOptimizationPriceData? MyBusinessUpdates { get; set; }

    [Display("Questions and answers")]
    [JsonProperty("questions_and_answers")]
    public AppendixLlmResponsesAiOptimizationPriceData? QuestionsAndAnswers { get; set; }

    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixLlmResponsesAiOptimizationPriceData? Reviews { get; set; }
}
