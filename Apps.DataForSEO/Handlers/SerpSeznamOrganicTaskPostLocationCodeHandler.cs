using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpSeznamOrganicTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] SerpSeznamOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/seznam/locations", "location", input.LocationCode, null, "")
{
}
