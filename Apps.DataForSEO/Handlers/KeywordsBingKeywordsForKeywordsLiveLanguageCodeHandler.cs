using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordsForKeywordsLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingKeywordsForKeywordsLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/languages", "language", input.LocationCode, null, "")
{
}
