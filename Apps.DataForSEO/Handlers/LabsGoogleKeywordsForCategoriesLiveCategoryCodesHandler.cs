using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class LabsGoogleKeywordsForCategoriesLiveCategoryCodesHandler(InvocationContext context, [ActionParameter] LabsGoogleKeywordsForCategoriesLiveRequest input)
    : CatalogueHandler(context, "/v3/dataforseo_labs/categories", "category", input.LocationCode, null, "google")
{
}
