using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYahooOrganicLiveHtmlLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpYahooOrganicLiveHtmlRequest input)
    : CatalogueHandler(context, "/v3/serp/yahoo/languages", "language", input.LocationCode, null, "")
{
}
