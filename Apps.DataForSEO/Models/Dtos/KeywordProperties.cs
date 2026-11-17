using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordProperties
{
    [Display("Se type")]
    [JsonProperty("se_type")]
    public string? SeType { get; set; }

    [Display("Core keyword")]
    [JsonProperty("core_keyword")]
    public string? CoreKeyword { get; set; }

    [Display("Synonym clustering algorithm")]
    [JsonProperty("synonym_clustering_algorithm")]
    public string? SynonymClusteringAlgorithm { get; set; }

    [Display("Keyword difficulty")]
    [JsonProperty("keyword_difficulty")]
    public long? KeywordDifficulty { get; set; }

    [Display("Detected language")]
    [JsonProperty("detected_language")]
    public string? DetectedLanguage { get; set; }

    [Display("Is another language")]
    [JsonProperty("is_another_language")]
    public bool? IsAnotherLanguage { get; set; }

    [Display("Words count")]
    [JsonProperty("words_count")]
    public long? WordsCount { get; set; }
}
