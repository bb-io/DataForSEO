using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleAdsSearchVolumeLiveLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleAdsSearchVolumeLiveRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_ads/locations", "location", input.LocationCode, null, "")
{
}
