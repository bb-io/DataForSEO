using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleAutocompleteTaskGetAdvancedIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/serp/google/autocomplete/tasks_ready", "task", null, null, "")
{
}
