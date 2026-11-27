using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBusinessDataPriceData
{
    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Business listings")]
    [JsonProperty("business_listings")]
    public AppendixBusinessListingsBusinessDataPriceData? BusinessListings { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("Google")]
    [JsonProperty("google")]
    public AppendixGoogleBusinessDataPriceData? Google { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Tripadvisor")]
    [JsonProperty("tripadvisor")]
    public AppendixTrBusinessDataPriceDataInfo? Tripadvisor { get; set; }

    [Display("Trustpilot")]
    [JsonProperty("trustpilot")]
    public AppendixTrBusinessDataPriceDataInfo? Trustpilot { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
