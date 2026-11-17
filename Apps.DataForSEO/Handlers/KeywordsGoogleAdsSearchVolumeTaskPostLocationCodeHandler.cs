using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleAdsSearchVolumeTaskPostLocationCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleAdsSearchVolumeTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_ads/locations", "location", input.LocationCode, null, "")
{
}
