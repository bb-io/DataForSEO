using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RankedKeywordsInfo
{
    [Display("Page from keywords count top 3")]
    [JsonProperty("page_from_keywords_count_top_3")]
    public long? PageFromKeywordsCountTop3 { get; set; }

    [Display("Page from keywords count top 10")]
    [JsonProperty("page_from_keywords_count_top_10")]
    public long? PageFromKeywordsCountTop10 { get; set; }

    [Display("Page from keywords count top 100")]
    [JsonProperty("page_from_keywords_count_top_100")]
    public long? PageFromKeywordsCountTop100 { get; set; }
}
