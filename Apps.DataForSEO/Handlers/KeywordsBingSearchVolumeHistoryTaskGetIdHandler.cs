using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingSearchVolumeHistoryTaskGetIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/keywords_data/bing/search_volume_history/tasks_ready", "task", null, null, "")
{
}
