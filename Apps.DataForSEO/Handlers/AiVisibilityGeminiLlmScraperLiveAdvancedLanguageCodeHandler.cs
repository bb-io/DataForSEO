using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityGeminiLlmScraperLiveAdvancedLanguageCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityGeminiLlmScraperLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/gemini/llm_scraper/languages", "language", input.LocationCode, null, "")
{
}
