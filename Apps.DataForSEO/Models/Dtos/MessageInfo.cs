using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class MessageInfo
{
    [Display("Level")]
    [JsonProperty("level")]
    public string? Level { get; set; }

    [Display("Message")]
    [JsonProperty("message")]
    public string? Message { get; set; }
}
