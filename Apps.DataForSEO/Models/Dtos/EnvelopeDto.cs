using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class EnvelopeDto<T>
{
    [JsonProperty("status_code")]
    public int StatusCode { get; set; }

    [JsonProperty("status_message")]
    public string StatusMessage { get; set; } = string.Empty;

    [JsonProperty("cost")]
    public decimal Cost { get; set; }

    [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
    public List<TaskDto<T>> Tasks { get; set; } = [];
}
