using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpSeznamOrganicTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpSeznamOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/seznam/languages", "language", input.LocationCode, null, "")
{
}
