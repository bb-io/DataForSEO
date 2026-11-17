using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleTrendsExploreTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleTrendsExploreTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_trends/locations", "location", input.LocationCode, null, "")
{
}
