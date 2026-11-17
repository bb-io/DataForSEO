using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpNaverOrganicTaskGetHtmlIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/serp/naver/organic/tasks_ready", "task", null, null, "")
{
}
