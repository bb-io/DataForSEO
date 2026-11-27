using Apps.DataForSEO.Models.Requests;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO.Handlers;

public class SerpBaiduOrganicTaskPostLanguageCodeHandler(InvocationContext context, [ActionParameter] SerpBaiduOrganicTaskPostRequest input)
    : CatalogueHandler(context, "/v3/serp/baidu/languages", "language", input.LocationCode, null, "")
{
}
