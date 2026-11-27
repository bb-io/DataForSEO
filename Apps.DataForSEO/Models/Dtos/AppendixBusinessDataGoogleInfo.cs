using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBusinessDataGoogleInfo
{
    [Display("My business info")]
    [JsonProperty("my_business_info")]
    public AppendixInfo? MyBusinessInfo { get; set; }

    [Display("My business updates")]
    [JsonProperty("my_business_updates")]
    public AppendixInfo? MyBusinessUpdates { get; set; }

    [Display("Hotel info")]
    [JsonProperty("hotel_info")]
    public AppendixSerpDaysRatesDataInfo? HotelInfo { get; set; }

    [Display("Hotel searches")]
    [JsonProperty("hotel_searches")]
    public AppendixInfo? HotelSearches { get; set; }

    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixInfo? Reviews { get; set; }

    [Display("Questions and answers")]
    [JsonProperty("questions_and_answers")]
    public AppendixInfo? QuestionsAndAnswers { get; set; }

    [Display("Extended reviews")]
    [JsonProperty("extended_reviews")]
    public AppendixInfo? ExtendedReviews { get; set; }
}
