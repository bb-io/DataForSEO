using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleTrendsExploreLiveCategoryCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleTrendsExploreLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_trends/categories", "category", input.LocationCode, null, "")
{
}
