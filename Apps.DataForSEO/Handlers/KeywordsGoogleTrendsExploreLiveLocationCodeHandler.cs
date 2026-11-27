using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleTrendsExploreLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleTrendsExploreLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_trends/locations", "location", input.LocationCode, null, "")
{
}
