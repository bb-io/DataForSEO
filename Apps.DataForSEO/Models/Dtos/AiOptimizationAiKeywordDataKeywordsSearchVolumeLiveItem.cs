using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveItem
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Ai search volume")]
    [JsonProperty("ai_search_volume")]
    public long? AiSearchVolume { get; set; }

    [Display("Ai monthly searches")]
    [JsonProperty("ai_monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<AiMonthlySearches> AiMonthlySearches { get; set; } = [];
}
