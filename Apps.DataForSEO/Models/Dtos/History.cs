using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class History
{
    [Display("Year")]
    [JsonProperty("year")]
    public long? Year { get; set; }

    [Display("Month")]
    [JsonProperty("month")]
    public long? Month { get; set; }

    [Display("Keyword info")]
    [JsonProperty("keyword_info")]
    public KeywordInfo? KeywordInfo { get; set; }
}
