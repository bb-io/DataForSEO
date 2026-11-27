using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityChatGptLlmScraperTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityChatGptLlmScraperTaskPostRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/chat_gpt/llm_scraper/locations", "location", input.LocationCode, null, "")
{
}
