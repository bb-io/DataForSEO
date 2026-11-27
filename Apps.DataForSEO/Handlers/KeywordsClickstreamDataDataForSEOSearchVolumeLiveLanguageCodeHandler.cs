using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsClickstreamDataDataForSEOSearchVolumeLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsClickstreamDataDataForSEOSearchVolumeLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/clickstream_data/locations_and_languages", "language", input.LocationCode, null, "")
{
}
