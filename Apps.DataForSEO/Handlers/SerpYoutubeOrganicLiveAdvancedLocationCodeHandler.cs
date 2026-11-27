using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeOrganicLiveAdvancedLocationCodeHandler(InvocationContext context, [ActionParameter] SerpYoutubeOrganicLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/serp/youtube/locations", "location", input.LocationCode, null, "")
{
}
