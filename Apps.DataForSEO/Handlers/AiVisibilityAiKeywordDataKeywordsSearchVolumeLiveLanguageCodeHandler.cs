using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AiVisibilityAiKeywordDataKeywordsSearchVolumeLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] AiVisibilityAiKeywordDataKeywordsSearchVolumeLiveRequest input)
    : CatalogueHandler(context, "/v3/ai_optimization/ai_keyword_data/locations_and_languages", "language", input.LocationCode, null, "")
{
}
