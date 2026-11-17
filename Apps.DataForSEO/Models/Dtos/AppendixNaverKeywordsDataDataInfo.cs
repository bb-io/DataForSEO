using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixNaverKeywordsDataDataInfo
{
    [Display("Keywords for category")]
    [JsonProperty("keywords_for_category")]
    public AppendixInfo? KeywordsForCategory { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public AppendixInfo? SearchVolume { get; set; }
}
