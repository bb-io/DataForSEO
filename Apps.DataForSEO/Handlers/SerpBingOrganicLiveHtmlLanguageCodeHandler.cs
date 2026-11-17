using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBingOrganicLiveHtmlLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpBingOrganicLiveHtmlRequest input)
    : CatalogueHandler(context, "/v3/serp/bing/languages", "language", input.LocationCode, null, "")
{
}
