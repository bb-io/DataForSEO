using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveLocationCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/llm_mentions/locations_and_languages", "location", input.LocationCode, input.Platform, "")
{
}
