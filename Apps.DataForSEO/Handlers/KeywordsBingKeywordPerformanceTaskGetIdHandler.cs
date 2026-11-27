using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingKeywordPerformanceTaskGetIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/keywords_data/bing/keyword_performance/tasks_ready", "task", null, null, "")
{
}
