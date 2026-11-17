using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class LabsGoogleSubdomainsLiveLocationCodeHandler(InvocationContext context, [ActionParameter] LabsGoogleSubdomainsLiveRequest input)
    : CatalogueHandler(context, "/v3/dataforseo_labs/locations_and_languages", "location", input.LocationCode, null, "google")
{
}
