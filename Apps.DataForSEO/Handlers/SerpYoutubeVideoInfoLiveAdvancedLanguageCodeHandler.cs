using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeVideoInfoLiveAdvancedLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpYoutubeVideoInfoLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/serp/youtube/languages", "language", input.LocationCode, null, "")
{
}
