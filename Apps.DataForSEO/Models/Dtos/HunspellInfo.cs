using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HunspellInfo
{
    [Display("Hunspell language code")]
    [JsonProperty("hunspell_language_code")]
    public string? HunspellLanguageCode { get; set; }

    [Display("Misspelled")]
    [JsonProperty("misspelled", NullValueHandling = NullValueHandling.Ignore)]
    public List<HunspellMisspelledInfo> Misspelled { get; set; } = [];
}
