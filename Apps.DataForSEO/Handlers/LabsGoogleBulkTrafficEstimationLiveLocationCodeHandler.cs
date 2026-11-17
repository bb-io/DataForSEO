using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class LabsGoogleBulkTrafficEstimationLiveLocationCodeHandler(InvocationContext context, [ActionParameter] LabsGoogleBulkTrafficEstimationLiveRequest input)
    : CatalogueHandler(context, "/v3/dataforseo_labs/locations_and_languages", "location", input.LocationCode, null, "google")
{
}
