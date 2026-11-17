using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixMerchantLimitsRatesDataInfo
{
    [Display("Google")]
    [JsonProperty("google")]
    public AppendixMerchantGoogleInfo? Google { get; set; }

    [Display("Amazon")]
    [JsonProperty("amazon")]
    public AppendixMerchantAmazonInfo? Amazon { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixSerpDaysRatesDataInfo? Reviews { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }
}
