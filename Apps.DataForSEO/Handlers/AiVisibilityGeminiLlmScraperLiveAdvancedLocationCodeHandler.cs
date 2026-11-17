using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityGeminiLlmScraperLiveAdvancedLocationCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityGeminiLlmScraperLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/gemini/llm_scraper/locations", "location", input.LocationCode, null, "")
{
}
