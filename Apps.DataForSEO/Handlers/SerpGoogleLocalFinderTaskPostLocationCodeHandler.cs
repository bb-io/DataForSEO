using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleLocalFinderTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] SerpGoogleLocalFinderTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/google/locations", "location", input.LocationCode, null, "")
{
}
