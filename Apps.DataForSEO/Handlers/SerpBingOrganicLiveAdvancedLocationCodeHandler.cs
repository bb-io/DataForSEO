using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBingOrganicLiveAdvancedLocationCodeHandler(InvocationContext context, [ActionParameter] SerpBingOrganicLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/serp/bing/locations", "location", input.LocationCode, null, "")
{
}
