using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordPerformanceTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingKeywordPerformanceTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/keyword_performance/locations_and_languages", "location", input.LocationCode, null, "")
{
}
