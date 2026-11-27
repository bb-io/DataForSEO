using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleSearchIntentLiveItem
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Keyword intent")]
    [JsonProperty("keyword_intent")]
    public KeywordIntentInfo? KeywordIntent { get; set; }

    [Display("Secondary keyword intents")]
    [JsonProperty("secondary_keyword_intents", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeywordIntentInfo> SecondaryKeywordIntents { get; set; } = [];
}
