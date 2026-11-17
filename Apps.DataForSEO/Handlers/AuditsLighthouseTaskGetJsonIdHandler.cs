using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AuditsLighthouseTaskGetJsonIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/on_page/lighthouse/tasks_ready", "task", null, null, "")
{
}
