using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TaskDto<T>
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("status_code")]
    public int StatusCode { get; set; }

    [JsonProperty("status_message")]
    public string StatusMessage { get; set; } = string.Empty;

    [JsonProperty("cost")]
    public decimal Cost { get; set; }

    [JsonProperty("data")]
    public TaskRequestDataDto? Data { get; set; }

    [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
    public List<T>? Result { get; set; }
}
