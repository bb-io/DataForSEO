using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsDataForSEOTrendsExploreLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsDataForSEOTrendsExploreLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/dataforseo_trends/locations", "location", input.LocationCode, null, "")
{
}
