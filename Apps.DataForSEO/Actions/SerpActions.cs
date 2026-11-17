using Apps.DataForSEO.Models.Dtos;
using Apps.DataForSEO.Models.Requests;
using Apps.DataForSEO.Models.Responses;
using Apps.DataForSEO.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.DataForSEO.Actions;

[ActionList("SERP")]
public class SerpActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Get SERP screenshot", Description = "\u200c\u200c Using the Live Page Screenshot endpoint, you can capture a screenshot of any SERP page.")]
    public async Task<ReportResponse<SerpScreenshotResultInfo>> SerpScreenshot([ActionParameter] SerpScreenshotRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["task_id"] = input.TaskId;
        if (input.BrowserPreset != null)
            body["browser_preset"] = input.BrowserPreset;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.Page != null)
            body["page"] = input.Page;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/screenshot", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpScreenshotResultInfo>(fileManagementClient, [response], "SerpScreenshot", false);
    }

    [Action("Get SERP AI summary", Description = "\u200c\u200c The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user\u2019s specified prompt. To obtain results, you have to specify task_i")]
    public async Task<ReportResponse<SerpAiSummaryResultInfo>> SerpAiSummary([ActionParameter] SerpAiSummaryRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["task_id"] = input.TaskId;
        if (input.Prompt != null)
            body["prompt"] = input.Prompt;
        if (input.SupportExtra != null)
            body["support_extra"] = input.SupportExtra;
        if (input.FetchContent != null)
            body["fetch_content"] = input.FetchContent;
        if (input.IncludeLinks != null)
            body["include_links"] = input.IncludeLinks;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/ai_summary", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpAiSummaryResultInfo>(fileManagementClient, [response], "SerpAiSummary", false);
    }

    [Action("Create Google organic SERP task", Description = "\u200c\u200c SERP API provides top 10 search engine results by default. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleOrganicTaskPost([ActionParameter] SerpGoogleOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.LoadAsyncAiOverview != null)
            body["load_async_ai_overview"] = input.LoadAsyncAiOverview;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.RemoveFromUrl != null)
            body["remove_from_url"] = input.RemoveFromUrl;
        if (input.ExpandAiOverview != null)
            body["expand_ai_overview"] = input.ExpandAiOverview;
        if (input.PeopleAlsoAskClickDepth != null)
            body["people_also_ask_click_depth"] = input.PeopleAlsoAskClickDepth;
        if (input.GroupOrganicResults != null)
            body["group_organic_results"] = input.GroupOrganicResults;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleOrganicTaskPost", false);
    }

    [Action("Get Google organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleOrganicTaskGetAdvancedResultInfo>> SerpGoogleOrganicTaskGetAdvanced([ActionParameter] SerpGoogleOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleOrganicTaskGetAdvanced", false);
    }

    [Action("Get Google organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleOrganicTaskGetHtmlResultInfo>> SerpGoogleOrganicTaskGetHtml([ActionParameter] SerpGoogleOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleOrganicTaskGetHtml", false);
    }

    [Action("Get Google organic SERP", Description = "\u200c Live SERP provides real-time data on top search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERP")]
    public async Task<ReportResponse<SerpGoogleOrganicLiveAdvancedResultInfo>> SerpGoogleOrganicLiveAdvanced([ActionParameter] SerpGoogleOrganicLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.LoadAsyncAiOverview != null)
            body["load_async_ai_overview"] = input.LoadAsyncAiOverview;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.RemoveFromUrl != null)
            body["remove_from_url"] = input.RemoveFromUrl;
        if (input.PeopleAlsoAskClickDepth != null)
            body["people_also_ask_click_depth"] = input.PeopleAlsoAskClickDepth;
        if (input.GroupOrganicResults != null)
            body["group_organic_results"] = input.GroupOrganicResults;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.Target != null)
            body["target"] = input.Target;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/organic/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleOrganicLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleOrganicLiveAdvanced", false);
    }

    [Action("Get Google organic HTML SERP", Description = "\u200c Live SERP HTML provides a raw HTML page of search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleOrganicLiveHtmlResultInfo>> SerpGoogleOrganicLiveHtml([ActionParameter] SerpGoogleOrganicLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.LoadAsyncAiOverview != null)
            body["load_async_ai_overview"] = input.LoadAsyncAiOverview;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.ExpandAiOverview != null)
            body["expand_ai_overview"] = input.ExpandAiOverview;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/organic/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleOrganicLiveHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleOrganicLiveHtml", false);
    }

    [Action("Create Google AI Mode SERP task", Description = "\u200c Google AI Mode SERP API provides search results from the AI Mode feature of Google Search.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleAiModeTaskPost([ActionParameter] SerpGoogleAiModeTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/ai_mode/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleAiModeTaskPost", false);
    }

    [Action("Get Google AI Mode SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleAiModeTaskGetAdvancedResultInfo>> SerpGoogleAiModeTaskGetAdvanced([ActionParameter] SerpGoogleAiModeTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/ai_mode/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAiModeTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleAiModeTaskGetAdvanced", false);
    }

    [Action("Get Google AI Mode HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleAiModeTaskGetHtmlResultInfo>> SerpGoogleAiModeTaskGetHtml([ActionParameter] SerpGoogleAiModeTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/ai_mode/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAiModeTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleAiModeTaskGetHtml", false);
    }

    [Action("Get Google AI Mode SERP", Description = "\u200c\u200c Google AI Mode SERP API provides search results from the AI Mode feature of Google Search.")]
    public async Task<ReportResponse<SerpGoogleAiModeLiveAdvancedResultInfo>> SerpGoogleAiModeLiveAdvanced([ActionParameter] SerpGoogleAiModeLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/ai_mode/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAiModeLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleAiModeLiveAdvanced", false);
    }

    [Action("Get Google AI Mode HTML SERP", Description = "\u200c Live SERP HTML provides a raw HTML page of a Google AI Mode search result for the specified keyword and location.")]
    public async Task<ReportResponse<SerpGoogleAiModeLiveHtmlResultInfo>> SerpGoogleAiModeLiveHtml([ActionParameter] SerpGoogleAiModeLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/ai_mode/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAiModeLiveHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleAiModeLiveHtml", false);
    }

    [Action("Create Google maps SERP task", Description = "\u200c\u200c SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleMapsTaskPost([ActionParameter] SerpGoogleMapsTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.SearchThisArea != null)
            body["search_this_area"] = input.SearchThisArea;
        if (input.SearchPlaces != null)
            body["search_places"] = input.SearchPlaces;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/maps/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleMapsTaskPost", false);
    }

    [Action("Get Google maps SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleMapsTaskGetAdvancedResultInfo>> SerpGoogleMapsTaskGetAdvanced([ActionParameter] SerpGoogleMapsTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/maps/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleMapsTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleMapsTaskGetAdvanced", false);
    }

    [Action("Get Google maps SERP", Description = "\u200c\u200c Live Google Maps SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleMapsLiveAdvancedResultInfo>> SerpGoogleMapsLiveAdvanced([ActionParameter] SerpGoogleMapsLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.SearchThisArea != null)
            body["search_this_area"] = input.SearchThisArea;
        if (input.SearchPlaces != null)
            body["search_places"] = input.SearchPlaces;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/maps/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleMapsLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleMapsLiveAdvanced", false);
    }

    [Action("Create Google local finder SERP task", Description = "\u200c\u200c Google Local Finder SERP API provides top search engine results specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleLocalFinderTaskPost([ActionParameter] SerpGoogleLocalFinderTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/local_finder/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleLocalFinderTaskPost", false);
    }

    [Action("Get Google local finder SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleLocalFinderTaskGetAdvancedResultInfo>> SerpGoogleLocalFinderTaskGetAdvanced([ActionParameter] SerpGoogleLocalFinderTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/local_finder/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleLocalFinderTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleLocalFinderTaskGetAdvanced", false);
    }

    [Action("Get Google local HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleLocalFinderTaskGetHtmlResultInfo>> SerpGoogleLocalFinderTaskGetHtml([ActionParameter] SerpGoogleLocalFinderTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/local_finder/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleLocalFinderTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleLocalFinderTaskGetHtml", false);
    }

    [Action("Get Google local finder SERP", Description = "\u200c\u200c Live Google Local_finder SERP provides real-time search engine results for the specified keyword and location.")]
    public async Task<ReportResponse<SerpGoogleLocalFinderLiveAdvancedResultInfo>> SerpGoogleLocalFinderLiveAdvanced([ActionParameter] SerpGoogleLocalFinderLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/local_finder/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleLocalFinderLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleLocalFinderLiveAdvanced", false);
    }

    [Action("Get Google local HTML SERP", Description = "\u200c Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleLocalFinderLiveHtmlResultInfo>> SerpGoogleLocalFinderLiveHtml([ActionParameter] SerpGoogleLocalFinderLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.MinRating != null)
            body["min_rating"] = input.MinRating;
        if (input.TimeFilter != null)
            body["time_filter"] = input.TimeFilter;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/local_finder/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleLocalFinderLiveHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleLocalFinderLiveHtml", false);
    }

    [Action("Create Google news SERP task", Description = "\u200c\u200c SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleNewsTaskPost([ActionParameter] SerpGoogleNewsTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/news/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleNewsTaskPost", false);
    }

    [Action("Get Google news SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleNewsTaskGetAdvancedResultInfo>> SerpGoogleNewsTaskGetAdvanced([ActionParameter] SerpGoogleNewsTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/news/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleNewsTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleNewsTaskGetAdvanced", false);
    }

    [Action("Get Google news HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleNewsTaskGetHtmlResultInfo>> SerpGoogleNewsTaskGetHtml([ActionParameter] SerpGoogleNewsTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/news/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleNewsTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleNewsTaskGetHtml", false);
    }

    [Action("Get Google news SERP", Description = "\u200c\u200c Live Google News SERP provides real-time data on top search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleNewsLiveAdvancedResultInfo>> SerpGoogleNewsLiveAdvanced([ActionParameter] SerpGoogleNewsLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/news/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleNewsLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleNewsLiveAdvanced", false);
    }

    [Action("Get Google news HTML SERP", Description = "\u200c Live SERP HTML provides a raw HTML page of 10 search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleNewsLiveHtmlResultInfo>> SerpGoogleNewsLiveHtml([ActionParameter] SerpGoogleNewsLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/news/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleNewsLiveHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleNewsLiveHtml", false);
    }

    [Action("Create Google images SERP task", Description = "\u200c\u200c SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleImagesTaskPost([ActionParameter] SerpGoogleImagesTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/images/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleImagesTaskPost", false);
    }

    [Action("Get Google images SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleImagesTaskGetAdvancedResultInfo>> SerpGoogleImagesTaskGetAdvanced([ActionParameter] SerpGoogleImagesTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/images/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleImagesTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleImagesTaskGetAdvanced", false);
    }

    [Action("Get Google images HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleImagesTaskGetHtmlResultInfo>> SerpGoogleImagesTaskGetHtml([ActionParameter] SerpGoogleImagesTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/images/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleImagesTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleImagesTaskGetHtml", false);
    }

    [Action("Get Google images SERP", Description = "\u200c Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleImagesLiveAdvancedResultInfo>> SerpGoogleImagesLiveAdvanced([ActionParameter] SerpGoogleImagesLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/images/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleImagesLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleImagesLiveAdvanced", false);
    }

    [Action("Get Google images HTML SERP", Description = "\u200c Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpGoogleImagesLiveHtmlResultInfo>> SerpGoogleImagesLiveHtml([ActionParameter] SerpGoogleImagesLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/images/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleImagesLiveHtmlResultInfo>(fileManagementClient, [response], "SerpGoogleImagesLiveHtml", false);
    }

    [Action("Create Google search by image SERP task", Description = "\u200c\u200c Google Search By Image SERP API provides up to top 100 search engine results based on the image you specified. These results are specific to the selected location (see the List of Locations) and language (see the List")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleSearchByImageTaskPost([ActionParameter] SerpGoogleSearchByImageTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.ImageUrl, "Image URL");
        body["image_url"] = input.ImageUrl;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.ResolveGotoUrls != null)
            body["resolve_goto_urls"] = input.ResolveGotoUrls;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/search_by_image/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleSearchByImageTaskPost", false);
    }

    [Action("Get Google search by image SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleSearchByImageTaskGetAdvancedResultInfo>> SerpGoogleSearchByImageTaskGetAdvanced([ActionParameter] SerpGoogleSearchByImageTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/search_by_image/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleSearchByImageTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleSearchByImageTaskGetAdvanced", false);
    }

    [Action("Create Google autocomplete SERP task", Description = "\u200c\u200c Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. the provider SERP API will provide you with all the suggestions Goog")]
    public async Task<ReportResponse<DynamicResult>> SerpGoogleAutocompleteTaskPost([ActionParameter] SerpGoogleAutocompleteTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.CursorPointer != null)
            body["cursor_pointer"] = input.CursorPointer;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Client != null)
            body["client"] = input.Client;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/autocomplete/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpGoogleAutocompleteTaskPost", false);
    }

    [Action("Get Google autocomplete SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpGoogleAutocompleteTaskGetAdvancedResultInfo>> SerpGoogleAutocompleteTaskGetAdvanced([ActionParameter] SerpGoogleAutocompleteTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/google/autocomplete/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAutocompleteTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleAutocompleteTaskGetAdvanced", false);
    }

    [Action("Get Google autocomplete SERP", Description = "\u200c\u200c Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. the provider SERP API will provide you with all the suggestions Goog")]
    public async Task<ReportResponse<SerpGoogleAutocompleteLiveAdvancedResultInfo>> SerpGoogleAutocompleteLiveAdvanced([ActionParameter] SerpGoogleAutocompleteLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.CursorPointer != null)
            body["cursor_pointer"] = input.CursorPointer;
        if (input.Client != null)
            body["client"] = input.Client;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/google/autocomplete/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpGoogleAutocompleteLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpGoogleAutocompleteLiveAdvanced", false);
    }

    [Action("Create Bing organic SERP task", Description = "SERP API provides search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpBingOrganicTaskPost([ActionParameter] SerpBingOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/bing/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpBingOrganicTaskPost", false);
    }

    [Action("Get Bing organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpBingOrganicTaskGetAdvancedResultInfo>> SerpBingOrganicTaskGetAdvanced([ActionParameter] SerpBingOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/bing/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBingOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpBingOrganicTaskGetAdvanced", false);
    }

    [Action("Get Bing organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpBingOrganicTaskGetHtmlResultInfo>> SerpBingOrganicTaskGetHtml([ActionParameter] SerpBingOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/bing/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBingOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpBingOrganicTaskGetHtml", false);
    }

    [Action("Get Bing organic SERP", Description = "Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SE")]
    public async Task<ReportResponse<SerpBingOrganicLiveAdvancedResultInfo>> SerpBingOrganicLiveAdvanced([ActionParameter] SerpBingOrganicLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.Target != null)
            body["target"] = input.Target;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenResolutionRatio != null)
            body["browser_screen_resolution_ratio"] = input.BrowserScreenResolutionRatio;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/bing/organic/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBingOrganicLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpBingOrganicLiveAdvanced", false);
    }

    [Action("Get Bing organic HTML SERP", Description = "Live SERP HTML provides a raw HTML page of search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpBingOrganicLiveHtmlResultInfo>> SerpBingOrganicLiveHtml([ActionParameter] SerpBingOrganicLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/bing/organic/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBingOrganicLiveHtmlResultInfo>(fileManagementClient, [response], "SerpBingOrganicLiveHtml", false);
    }

    [Action("Create YouTube video info SERP task", Description = "\u200c\u200c YouTube Video Info API provides detailed information about the video you specify in the POST request. You will get data from the watching page containing key video and content metrics as well as the channel where the ")]
    public async Task<ReportResponse<DynamicResult>> SerpYoutubeVideoInfoTaskPost([ActionParameter] SerpYoutubeVideoInfoTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.VideoId, "Video ID");
        body["video_id"] = input.VideoId;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/youtube/video_info/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpYoutubeVideoInfoTaskPost", false);
    }

    [Action("Get YouTube video info SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpYoutubeVideoInfoTaskGetAdvancedResultInfo>> SerpYoutubeVideoInfoTaskGetAdvanced([ActionParameter] SerpYoutubeVideoInfoTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/youtube/video_info/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYoutubeVideoInfoTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpYoutubeVideoInfoTaskGetAdvanced", false);
    }

    [Action("Get YouTube video info SERP", Description = "\u200c Live YouTube Video Info provides real-time data on the video you specify in the request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is publi")]
    public async Task<ReportResponse<SerpYoutubeVideoInfoLiveAdvancedResultInfo>> SerpYoutubeVideoInfoLiveAdvanced([ActionParameter] SerpYoutubeVideoInfoLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.VideoId, "Video ID");
        body["video_id"] = input.VideoId;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/youtube/video_info/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYoutubeVideoInfoLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpYoutubeVideoInfoLiveAdvanced", false);
    }

    [Action("Create YouTube organic SERP task", Description = "\u200c\u200c YouTube Organic API provides the top 20 blocks of search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpYoutubeOrganicTaskPost([ActionParameter] SerpYoutubeOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.BlockDepth != null)
            body["block_depth"] = input.BlockDepth;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/youtube/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpYoutubeOrganicTaskPost", false);
    }

    [Action("Get YouTube organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpYoutubeOrganicTaskGetAdvancedResultInfo>> SerpYoutubeOrganicTaskGetAdvanced([ActionParameter] SerpYoutubeOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/youtube/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYoutubeOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpYoutubeOrganicTaskGetAdvanced", false);
    }

    [Action("Get YouTube organic SERP", Description = "\u200c Live SERP provides real-time data on the top 20 blocks of YouTube search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings")]
    public async Task<ReportResponse<SerpYoutubeOrganicLiveAdvancedResultInfo>> SerpYoutubeOrganicLiveAdvanced([ActionParameter] SerpYoutubeOrganicLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.BlockDepth != null)
            body["block_depth"] = input.BlockDepth;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/youtube/organic/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYoutubeOrganicLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpYoutubeOrganicLiveAdvanced", false);
    }

    [Action("Create Yahoo organic SERP task", Description = "\u200c\u200c SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpYahooOrganicTaskPost([ActionParameter] SerpYahooOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/yahoo/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpYahooOrganicTaskPost", false);
    }

    [Action("Get Yahoo organic SERP results", Description = "Description of the fields for sending a request: for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'")]
    public async Task<ReportResponse<SerpYahooOrganicTaskGetAdvancedResultInfo>> SerpYahooOrganicTaskGetAdvanced([ActionParameter] SerpYahooOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/yahoo/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYahooOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpYahooOrganicTaskGetAdvanced", false);
    }

    [Action("Get Yahoo organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpYahooOrganicTaskGetHtmlResultInfo>> SerpYahooOrganicTaskGetHtml([ActionParameter] SerpYahooOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/yahoo/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYahooOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpYahooOrganicTaskGetHtml", false);
    }

    [Action("Get Yahoo organic SERP", Description = "Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings. for more info please visi")]
    public async Task<ReportResponse<SerpYahooOrganicLiveAdvancedResultInfo>> SerpYahooOrganicLiveAdvanced([ActionParameter] SerpYahooOrganicLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.Target != null)
            body["target"] = input.Target;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/yahoo/organic/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYahooOrganicLiveAdvancedResultInfo>(fileManagementClient, [response], "SerpYahooOrganicLiveAdvanced", false);
    }

    [Action("Get Yahoo organic HTML SERP", Description = "Live SERP HTML provides a raw HTML page of search engine results for the specified keyword, search engine, and location.")]
    public async Task<ReportResponse<SerpYahooOrganicLiveHtmlResultInfo>> SerpYahooOrganicLiveHtml([ActionParameter] SerpYahooOrganicLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Url != null)
            body["url"] = input.Url;
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/yahoo/organic/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpYahooOrganicLiveHtmlResultInfo>(fileManagementClient, [response], "SerpYahooOrganicLiveHtml", false);
    }

    [Action("Create Baidu organic SERP task", Description = "Baidu SERP API provides top 10 search engine results. These results are specific to the selected location (see the List of Locations) and other settings.")]
    public async Task<ReportResponse<DynamicResult>> SerpBaiduOrganicTaskPost([ActionParameter] SerpBaiduOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.GetWebsiteUrl != null)
            body["get_website_url"] = input.GetWebsiteUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/baidu/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpBaiduOrganicTaskPost", false);
    }

    [Action("Get Baidu organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpBaiduOrganicTaskGetAdvancedResultInfo>> SerpBaiduOrganicTaskGetAdvanced([ActionParameter] SerpBaiduOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/baidu/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBaiduOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpBaiduOrganicTaskGetAdvanced", false);
    }

    [Action("Get Baidu organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpBaiduOrganicTaskGetHtmlResultInfo>> SerpBaiduOrganicTaskGetHtml([ActionParameter] SerpBaiduOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/baidu/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpBaiduOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpBaiduOrganicTaskGetHtml", false);
    }

    [Action("Create Naver organic SERP task", Description = "\u200c\u200c Naver SERP API provides top 20 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However")]
    public async Task<ReportResponse<DynamicResult>> SerpNaverOrganicTaskPost([ActionParameter] SerpNaverOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/naver/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpNaverOrganicTaskPost", false);
    }

    [Action("Get Naver organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpNaverOrganicTaskGetAdvancedResultInfo>> SerpNaverOrganicTaskGetAdvanced([ActionParameter] SerpNaverOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/naver/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpNaverOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpNaverOrganicTaskGetAdvanced", false);
    }

    [Action("Get Naver organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpNaverOrganicTaskGetHtmlResultInfo>> SerpNaverOrganicTaskGetHtml([ActionParameter] SerpNaverOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/naver/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpNaverOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpNaverOrganicTaskGetHtml", false);
    }

    [Action("Create Seznam organic SERP task", Description = "\u200c\u200c Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.")]
    public async Task<ReportResponse<DynamicResult>> SerpSeznamOrganicTaskPost([ActionParameter] SerpSeznamOrganicTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        if (input.Depth != null)
            body["depth"] = input.Depth;
        if (input.MaxCrawlPages != null)
            body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Os != null)
            body["os"] = input.Os;
        if (input.SeDomain != null)
            body["se_domain"] = input.SeDomain;
        if (input.SearchParam != null)
            body["search_param"] = input.SearchParam;
        if (input.CalculateRectangles != null)
            body["calculate_rectangles"] = input.CalculateRectangles;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        InputValidator.Required(input.PostbackData, "Postback data");
        body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/serp/seznam/organic/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "SerpSeznamOrganicTaskPost", false);
    }

    [Action("Get Seznam organic SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpSeznamOrganicTaskGetAdvancedResultInfo>> SerpSeznamOrganicTaskGetAdvanced([ActionParameter] SerpSeznamOrganicTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/seznam/organic/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpSeznamOrganicTaskGetAdvancedResultInfo>(fileManagementClient, [response], "SerpSeznamOrganicTaskGetAdvanced", false);
    }

    [Action("Get Seznam organic HTML SERP results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<SerpSeznamOrganicTaskGetHtmlResultInfo>> SerpSeznamOrganicTaskGetHtml([ActionParameter] SerpSeznamOrganicTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/serp/seznam/organic/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<SerpSeznamOrganicTaskGetHtmlResultInfo>(fileManagementClient, [response], "SerpSeznamOrganicTaskGetHtml", false);
    }
}
