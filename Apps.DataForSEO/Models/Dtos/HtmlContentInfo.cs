using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HtmlContentInfo
{
    [Display("Plain text size")]
    [JsonProperty("plain_text_size")]
    public long? PlainTextSize { get; set; }

    [Display("Plain text rate")]
    [JsonProperty("plain_text_rate")]
    public double? PlainTextRate { get; set; }

    [Display("Plain text word count")]
    [JsonProperty("plain_text_word_count")]
    public long? PlainTextWordCount { get; set; }

    [Display("Automated readability index")]
    [JsonProperty("automated_readability_index")]
    public double? AutomatedReadabilityIndex { get; set; }

    [Display("Coleman liau readability index")]
    [JsonProperty("coleman_liau_readability_index")]
    public double? ColemanLiauReadabilityIndex { get; set; }

    [Display("Dale chall readability index")]
    [JsonProperty("dale_chall_readability_index")]
    public double? DaleChallReadabilityIndex { get; set; }

    [Display("Flesch kincaid readability index")]
    [JsonProperty("flesch_kincaid_readability_index")]
    public double? FleschKincaidReadabilityIndex { get; set; }

    [Display("Smog readability index")]
    [JsonProperty("smog_readability_index")]
    public double? SmogReadabilityIndex { get; set; }

    [Display("Description to content consistency")]
    [JsonProperty("description_to_content_consistency")]
    public double? DescriptionToContentConsistency { get; set; }

    [Display("Title to content consistency")]
    [JsonProperty("title_to_content_consistency")]
    public double? TitleToContentConsistency { get; set; }

    [Display("Meta keywords to content consistency")]
    [JsonProperty("meta_keywords_to_content_consistency")]
    public double? MetaKeywordsToContentConsistency { get; set; }
}
