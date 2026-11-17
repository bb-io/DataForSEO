using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class ContentCategoryTrendsLiveCategoryCodeHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/content_analysis/categories", "category", null, null, "")
{
}
