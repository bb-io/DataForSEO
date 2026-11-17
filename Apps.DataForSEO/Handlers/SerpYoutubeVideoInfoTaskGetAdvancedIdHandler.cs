using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeVideoInfoTaskGetAdvancedIdHandler(InvocationContext context)
    : CatalogueHandler(context, "/v3/serp/youtube/video_info/tasks_ready", "task", null, null, "")
{
}
