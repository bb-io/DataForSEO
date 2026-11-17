using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAppDataPriceData
{
    [Display("App info")]
    [JsonProperty("app_info")]
    public AppendixProductGoogleMerchantPriceDataInfo? AppInfo { get; set; }

    [Display("App listings")]
    [JsonProperty("app_listings")]
    public AppendixLlmMentionsAiOptimizationPriceData? AppListings { get; set; }

    [Display("App list")]
    [JsonProperty("app_list")]
    public AppendixProductGoogleMerchantPriceDataInfo? AppList { get; set; }

    [Display("App reviews")]
    [JsonProperty("app_reviews")]
    public AppendixPriceDataInfo? AppReviews { get; set; }

    [Display("App searches")]
    [JsonProperty("app_searches")]
    public AppendixProductGoogleMerchantPriceDataInfo? AppSearches { get; set; }

    [Display("Pp listings")]
    [JsonProperty("pp_listings")]
    public AppendixLlmMentionsAiOptimizationPriceData? PpListings { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public AppendixTaskKeywordsDataPriceDataInfo? Categories { get; set; }

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

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
