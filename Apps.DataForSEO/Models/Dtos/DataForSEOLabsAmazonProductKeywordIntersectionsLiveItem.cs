using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsAmazonProductKeywordIntersectionsLiveItem
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Keyword data")]
    [JsonProperty("keyword_data")]
    public AmazonKeywordData? KeywordData { get; set; }

    [Display("Intersection result")]
    [JsonProperty("intersection_result")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? IntersectionResult { get; set; }
}
