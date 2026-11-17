using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpYoutubeOrganicTaskPostOsCatalogueHandler([ActionParameter] SerpYoutubeOrganicTaskPostRequest input)
    : DeviceCatalogueHandler(input.Device, "os")
{
}
