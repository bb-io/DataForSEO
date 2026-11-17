using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataBingKeywordPerformanceLiveResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Keyword kpi")]
    [JsonProperty("keyword_kpi")]
    public KeywordKpi? KeywordKpi { get; set; }
}
