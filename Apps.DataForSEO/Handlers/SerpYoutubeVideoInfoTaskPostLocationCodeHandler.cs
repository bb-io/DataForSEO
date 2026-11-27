using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeVideoInfoTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] SerpYoutubeVideoInfoTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/youtube/locations", "location", input.LocationCode, null, "")
{
}
