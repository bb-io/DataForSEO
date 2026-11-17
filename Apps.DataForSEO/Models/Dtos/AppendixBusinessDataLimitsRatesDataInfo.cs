using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBusinessDataLimitsRatesDataInfo
{
    [Display("Google")]
    [JsonProperty("google")]
    public AppendixBusinessDataGoogleInfo? Google { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Tripadvisor")]
    [JsonProperty("tripadvisor")]
    public AppendixTrBusinessDataDayLimitsRatesDataInfo? Tripadvisor { get; set; }

    [Display("Trustpilot")]
    [JsonProperty("trustpilot")]
    public AppendixTrBusinessDataDayLimitsRatesDataInfo? Trustpilot { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Business listings")]
    [JsonProperty("business_listings")]
    public AppendixBusinessListingsBusinessDataLimitsRatesDataInfo? BusinessListings { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }
}
