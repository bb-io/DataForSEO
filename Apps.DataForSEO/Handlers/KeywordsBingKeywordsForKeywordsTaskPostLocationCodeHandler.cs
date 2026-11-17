using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordsForKeywordsTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingKeywordsForKeywordsTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/locations", "location", input.LocationCode, null, "")
{
}
