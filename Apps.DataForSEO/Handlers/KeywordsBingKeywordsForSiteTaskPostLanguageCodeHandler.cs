using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordsForSiteTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingKeywordsForSiteTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/languages", "language", input.LocationCode, null, "")
{
}
