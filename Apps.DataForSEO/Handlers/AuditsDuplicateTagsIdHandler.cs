using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class AuditsDuplicateTagsIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/on_page/tasks_ready", "task", null, null, "")
{
}
