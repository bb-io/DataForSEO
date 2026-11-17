using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpGoogleLocalFinderLiveHtmlMinRatingCatalogueHandler([ActionParameter] SerpGoogleLocalFinderLiveHtmlRequest input)
    : DeviceCatalogueHandler(input.Device, "min_rating")
{
}
