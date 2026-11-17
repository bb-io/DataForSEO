using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordInfoNormalizedWithInfo
{
    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Is normalized")]
    [JsonProperty("is_normalized")]
    public bool? IsNormalized { get; set; }

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];
}
