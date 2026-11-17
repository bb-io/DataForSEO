using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleAiModeLiveAdvancedOsCatalogueHandler([ActionParameter] SerpGoogleAiModeLiveAdvancedRequest input)
    : DeviceCatalogueHandler(input.Device, "os")
{
}
