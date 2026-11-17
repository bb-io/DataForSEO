using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsDataForSEOTrendsSubregionInterestsLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsDataForSEOTrendsSubregionInterestsLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/dataforseo_trends/locations", "location", input.LocationCode, null, "")
{
}
