using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ChatGptBrandEntity
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Category")]
    [JsonProperty("category")]
    public string? Category { get; set; }

    [Display("Markdown")]
    [JsonProperty("markdown")]
    public string? Markdown { get; set; }

    [Display("URLS")]
    [JsonProperty("urls")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Urls { get; set; }
}
