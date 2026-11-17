using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleAdsSearchVolumeTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleAdsSearchVolumeTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_ads/languages", "language", input.LocationCode, null, "")
{
}
