using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleAiModeLiveHtmlLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpGoogleAiModeLiveHtmlRequest input)
    : CatalogueHandler(context, "/v3/serp/google/ai_mode/languages", "language", input.LocationCode, null, "")
{
}
