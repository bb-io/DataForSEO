using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixMerchantPriceData
{
    [Display("Google")]
    [JsonProperty("google")]
    public AppendixGoogleMerchantPriceData? Google { get; set; }

    [Display("Amazon")]
    [JsonProperty("amazon")]
    public AppendixAmazonMerchantPriceData? Amazon { get; set; }

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

    [Display("Reviews")]
    [JsonProperty("reviews")]
    public AppendixProductGoogleMerchantPriceDataInfo? Reviews { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
