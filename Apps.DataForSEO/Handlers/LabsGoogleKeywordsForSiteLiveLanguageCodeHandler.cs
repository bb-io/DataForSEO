using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class LabsGoogleKeywordsForSiteLiveLanguageCodeHandler(InvocationContext context, [ActionParameter] LabsGoogleKeywordsForSiteLiveRequest input)
    : CatalogueHandler(context, "/v3/dataforseo_labs/locations_and_languages", "language", input.LocationCode, null, "google")
{
}
