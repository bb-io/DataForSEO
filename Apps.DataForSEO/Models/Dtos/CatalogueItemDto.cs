using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class CatalogueItemDto
{
    [JsonProperty("location_code")]
    public string? LocationCode { get; set; }

    [JsonProperty("location_name")]
    public string? LocationName { get; set; }

    [JsonProperty("location_type")]
    public string? LocationType { get; set; }

    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [JsonProperty("language_name")]
    public string? LanguageName { get; set; }

    [JsonProperty("available_locations", NullValueHandling = NullValueHandling.Ignore)]
    public List<CatalogueItemDto>? AvailableLocations { get; set; }

    [JsonProperty("available_languages", NullValueHandling = NullValueHandling.Ignore)]
    public List<CatalogueLanguageDto>? AvailableLanguages { get; set; }

    [JsonProperty("category_code")]
    public string? CategoryCode { get; set; }

    [JsonProperty("category_name")]
    public string? CategoryName { get; set; }

    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
