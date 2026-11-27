using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class CatalogueLanguageDto
{
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [JsonProperty("language_name")]
    public string? LanguageName { get; set; }

    [JsonProperty("available_sources", NullValueHandling = NullValueHandling.Ignore)]
    public List<string>? AvailableSources { get; set; }
}
