using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYahooOrganicLiveAdvancedLocationCodeHandler(InvocationContext context, [ActionParameter] SerpYahooOrganicLiveAdvancedRequest input)
    : CatalogueHandler(context, "/v3/serp/yahoo/locations", "location", input.LocationCode, null, "")
{
}
