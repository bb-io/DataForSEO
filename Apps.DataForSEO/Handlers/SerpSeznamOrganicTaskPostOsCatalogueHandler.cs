using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpSeznamOrganicTaskPostOsCatalogueHandler([ActionParameter] SerpSeznamOrganicTaskPostRequest input)
    : DeviceCatalogueHandler(input.Device, "os")
{
}
