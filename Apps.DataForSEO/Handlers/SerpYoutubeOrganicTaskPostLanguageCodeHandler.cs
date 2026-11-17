using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeOrganicTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpYoutubeOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/youtube/languages", "language", input.LocationCode, null, "")
{
}
