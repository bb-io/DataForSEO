using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAiOptimizationLimitsRatesDataInfo
{
    [Display("LLM responses")]
    [JsonProperty("llm_responses")]
    public AppendixLlmResponsesAiOptimizationLimitsRatesDataInfo? LlmResponses { get; set; }

    [Display("Ai keyword data")]
    [JsonProperty("ai_keyword_data")]
    public AppendixAiKeywordDataAiOptimizationLimitsRatesDataInfo? AiKeywordData { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("LLM scraper")]
    [JsonProperty("llm_scraper")]
    public AppendixSerpDaysRatesDataInfo? LlmScraper { get; set; }

    [Display("LLM mentions")]
    [JsonProperty("llm_mentions")]
    public AppendixLlmMentionsAiOptimizationLimitsRatesDataInfo? LlmMentions { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }
}
