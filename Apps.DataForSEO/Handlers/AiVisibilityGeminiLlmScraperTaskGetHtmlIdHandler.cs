using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityGeminiLlmScraperTaskGetHtmlIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/ai_optimization/gemini/llm_scraper/tasks_ready", "task", null, null, "")
{
}
