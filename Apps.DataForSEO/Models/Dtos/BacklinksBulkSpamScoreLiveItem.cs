using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksBulkSpamScoreLiveItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Target")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Spam score")]
    [JsonProperty("spam_score")]
    public long? SpamScore { get; set; }
}
