using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixAiOptimizationPriceData
{
    [Display("LLM scraper")]
    [JsonProperty("llm_scraper")]
    public AppendixLlmScraperAiOptimizationPriceData? LlmScraper { get; set; }

    [Display("LLM mentions")]
    [JsonProperty("llm_mentions")]
    public AppendixLlmMentionsAiOptimizationPriceData? LlmMentions { get; set; }

    [Display("Ai keyword data")]
    [JsonProperty("ai_keyword_data")]
    public AppendixAiKeywordDataAiOptimizationPriceData? AiKeywordData { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("LLM responses")]
    [JsonProperty("llm_responses")]
    public AppendixLlmResponsesAiOptimizationPriceData? LlmResponses { get; set; }
}
