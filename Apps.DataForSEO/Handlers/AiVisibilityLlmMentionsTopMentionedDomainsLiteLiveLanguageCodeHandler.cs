using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityLlmMentionsTopMentionedDomainsLiteLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityLlmMentionsTopMentionedDomainsLiteLiveRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/llm_mentions/locations_and_languages", "language", input.LocationCode, input.Platform, "")
{
}
