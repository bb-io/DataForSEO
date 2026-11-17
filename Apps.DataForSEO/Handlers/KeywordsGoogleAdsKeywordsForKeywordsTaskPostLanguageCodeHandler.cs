using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class KeywordsGoogleAdsKeywordsForKeywordsTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] KeywordsGoogleAdsKeywordsForKeywordsTaskPostRequest input)
    : CatalogueHandler(context, "/v3/keywords_data/google_ads/languages", "language", input.LocationCode, null, "")
{
}
