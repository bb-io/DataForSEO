using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class UncrawlableResourcesMeta
{
    [Display("Content type")]
    [JsonProperty("content_type")]
    public string? ContentType { get; set; }

    [Display("Expected content types")]
    [JsonProperty("expected_content_types", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ExpectedContentTypes { get; set; } = [];
}
