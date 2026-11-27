using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBingOrganicTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] SerpBingOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/bing/locations", "location", input.LocationCode, null, "")
{
}
