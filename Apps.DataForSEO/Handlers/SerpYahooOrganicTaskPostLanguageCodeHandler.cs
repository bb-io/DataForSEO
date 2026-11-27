using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYahooOrganicTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpYahooOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/yahoo/languages", "language", input.LocationCode, null, "")
{
}
