using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingSearchVolumeLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingSearchVolumeLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/languages", "language", input.LocationCode, null, "")
{
}
