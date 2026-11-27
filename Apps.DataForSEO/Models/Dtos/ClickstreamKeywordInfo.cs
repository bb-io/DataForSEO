using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ClickstreamKeywordInfo
{
    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Last updated time")]
    [JsonProperty("last_updated_time")]
    public string? LastUpdatedTime { get; set; }

    [Display("Gender distribution")]
    [JsonProperty("gender_distribution")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? GenderDistribution { get; set; }

    [Display("Age distribution")]
    [JsonProperty("age_distribution")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? AgeDistribution { get; set; }

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];
}
