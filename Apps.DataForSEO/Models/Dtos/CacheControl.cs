using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class CacheControl
{
    [Display("Cachable")]
    [JsonProperty("cachable")]
    public bool? Cachable { get; set; }

    [Display("Ttl")]
    [JsonProperty("ttl")]
    public long? Ttl { get; set; }
}
