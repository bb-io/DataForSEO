using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleAdsKeywordsForSiteTaskGetIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/keywords_data/google_ads/keywords_for_site/tasks_ready", "task", null, null, "")
{
}
