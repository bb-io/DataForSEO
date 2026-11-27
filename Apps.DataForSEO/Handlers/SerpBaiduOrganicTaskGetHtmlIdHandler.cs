using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBaiduOrganicTaskGetHtmlIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/serp/baidu/organic/tasks_ready", "task", null, null, "")
{
}
