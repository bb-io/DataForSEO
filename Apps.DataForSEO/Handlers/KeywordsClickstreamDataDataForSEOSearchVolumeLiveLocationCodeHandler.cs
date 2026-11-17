using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsClickstreamDataDataForSEOSearchVolumeLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsClickstreamDataDataForSEOSearchVolumeLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/clickstream_data/locations_and_languages", "location", input.LocationCode, null, "")
{
}
