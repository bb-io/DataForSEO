using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBingOrganicLiveAdvancedOsCatalogueHandler([ActionParameter] SerpBingOrganicLiveAdvancedRequest input)
    : DeviceCatalogueHandler(input.Device, "os")
{
}
