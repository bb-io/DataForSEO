using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpScreenshotTaskIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/serp/tasks_ready", "task", null, null, "")
{
}
