using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleLocalFinderLiveHtmlLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpGoogleLocalFinderLiveHtmlRequest input)
    : CatalogueHandler(context, "/v3/serp/google/languages", "language", input.LocationCode, null, "")
{
}
