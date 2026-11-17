using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ReadyTaskDto
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
