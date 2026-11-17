using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYahooOrganicTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] SerpYahooOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/yahoo/locations", "location", input.LocationCode, null, "")
{
}
