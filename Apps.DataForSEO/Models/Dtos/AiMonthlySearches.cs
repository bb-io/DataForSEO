using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiMonthlySearches
{
    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Ai search volume")]
    [JsonProperty("ai_search_volume")]
    public long? AiSearchVolume { get; set; }
}
