using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class MicrodataFieldsInfo
{
    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("Types")]
    [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Types { get; set; } = [];

    [Display("Value")]
    [JsonProperty("value")]
    public string? Value { get; set; }

    [Display("Test results")]
    [JsonProperty("test_results")]
    public MessageInfo? TestResults { get; set; }

    [Display("Fields")]
    [JsonProperty("fields")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Fields { get; set; }
}
