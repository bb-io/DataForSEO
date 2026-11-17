using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class LabsGoogleCategoriesForKeywordsLiveLanguageCodeHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/dataforseo_labs/google/categories_for_keywords/languages", "language", null, null, "google")
{
}
