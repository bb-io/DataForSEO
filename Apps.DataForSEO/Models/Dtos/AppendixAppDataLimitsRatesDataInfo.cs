using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAppDataLimitsRatesDataInfo
{
    [Display("App info")]
    [JsonProperty("app_info")]
    public AppendixSerpDaysRatesDataInfo? AppInfo { get; set; }

    [Display("App list")]
    [JsonProperty("app_list")]
    public AppendixSerpDaysRatesDataInfo? AppList { get; set; }

    [Display("App reviews")]
    [JsonProperty("app_reviews")]
    public AppendixSerpDaysRatesDataInfo? AppReviews { get; set; }

    [Display("App searches")]
    [JsonProperty("app_searches")]
    public AppendixSerpDaysRatesDataInfo? AppSearches { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public double? Categories { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("App listings")]
    [JsonProperty("app_listings")]
    public AppendixTrBusinessDataDayLimitsRatesDataInfo? AppListings { get; set; }

    [Display("Pp listings")]
    [JsonProperty("pp_listings")]
    public AppendixDataForSEOLabsLimitsRatesDataInfo? PpListings { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }
}
