using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordsForKeywordsTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingKeywordsForKeywordsTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/languages", "language", input.LocationCode, null, "")
{
}
