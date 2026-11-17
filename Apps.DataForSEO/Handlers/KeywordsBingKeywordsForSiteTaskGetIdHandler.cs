using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordsForSiteTaskGetIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/keywords_data/bing/keywords_for_site/tasks_ready", "task", null, null, "")
{
}
