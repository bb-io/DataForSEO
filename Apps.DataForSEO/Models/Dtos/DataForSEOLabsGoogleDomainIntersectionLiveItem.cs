using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleDomainIntersectionLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Keyword data")]
    [JsonProperty("keyword_data")]
    public KeywordDataInfo? KeywordData { get; set; }

    [Display("First domain SERP element")]
    [JsonProperty("first_domain_serp_element")]
    public BaseDataForSEOLabsApiElementItem? FirstDomainSerpElement { get; set; }

    [Display("Second domain SERP element")]
    [JsonProperty("second_domain_serp_element")]
    public BaseDataForSEOLabsApiElementItem? SecondDomainSerpElement { get; set; }
}
