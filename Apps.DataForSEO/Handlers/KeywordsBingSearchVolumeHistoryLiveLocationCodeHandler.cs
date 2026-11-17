using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsBingSearchVolumeHistoryLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsBingSearchVolumeHistoryLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/bing/search_volume_history/locations_and_languages", "location", input.LocationCode, null, "")
{
}
