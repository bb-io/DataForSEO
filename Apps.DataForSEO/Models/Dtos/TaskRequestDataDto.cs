using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TaskRequestDataDto
{
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
