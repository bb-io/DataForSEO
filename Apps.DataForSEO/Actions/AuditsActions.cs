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

[ActionList("Site audits")]
public class AuditsActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Stop site audit", Description = "\u200c\u200c This endpoint is designed to force stop the crawl process of websites you specified in a task. The execution of all the tasks associated with the IDs indicated in your request to this endpoint will be stopped. You wil")]
    public async Task<ReportResponse<DynamicResult>> AuditsForceStop([ActionParameter] AuditsForceStopRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/force_stop", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AuditsForceStop", false);
    }

    [Action("Create site audit", Description = "\u200c OnPage API checks websites for 60+ customizable on-page parameters defines and displays all found flaws and opportunities for optimization so that you can easily fix them. It checks meta tags, duplicate content, image ")]
    public async Task<ReportResponse<DynamicResult>> AuditsTaskPost([ActionParameter] AuditsTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.MaxCrawlPages, "Max crawl pages");
        body["max_crawl_pages"] = input.MaxCrawlPages;
        if (input.StartUrl != null)
            body["start_url"] = input.StartUrl;
        if (input.ForceSitewideChecks != null)
            body["force_sitewide_checks"] = input.ForceSitewideChecks;
        if (input.PriorityUrls != null)
            body["priority_urls"] = input.PriorityUrls;
        if (input.MaxCrawlDepth != null)
            body["max_crawl_depth"] = input.MaxCrawlDepth;
        if (input.CrawlDelay != null)
            body["crawl_delay"] = input.CrawlDelay;
        if (input.StoreRawHtml != null)
            body["store_raw_html"] = input.StoreRawHtml;
        if (input.EnableContentParsing != null)
            body["enable_content_parsing"] = input.EnableContentParsing;
        if (input.SupportCookies != null)
            body["support_cookies"] = input.SupportCookies;
        if (input.AcceptLanguage != null)
            body["accept_language"] = input.AcceptLanguage;
        if (input.CustomRobotsTxt != null)
            body["custom_robots_txt"] = input.CustomRobotsTxt;
        if (input.RobotsTxtMergeMode != null)
            body["robots_txt_merge_mode"] = input.RobotsTxtMergeMode;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserPreset != null)
            body["browser_preset"] = input.BrowserPreset;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.RespectSitemap != null)
            body["respect_sitemap"] = input.RespectSitemap;
        if (input.CustomSitemap != null)
            body["custom_sitemap"] = input.CustomSitemap;
        if (input.CrawlSitemapOnly != null)
            body["crawl_sitemap_only"] = input.CrawlSitemapOnly;
        if (input.LoadResources != null)
            body["load_resources"] = input.LoadResources;
        if (input.EnableWwwRedirectCheck != null)
            body["enable_www_redirect_check"] = input.EnableWwwRedirectCheck;
        if (input.EnableJavascript != null)
            body["enable_javascript"] = input.EnableJavascript;
        if (input.EnableXhr != null)
            body["enable_xhr"] = input.EnableXhr;
        if (input.EnableBrowserRendering != null)
            body["enable_browser_rendering"] = input.EnableBrowserRendering;
        if (input.DisableCookiePopup != null)
            body["disable_cookie_popup"] = input.DisableCookiePopup;
        if (input.CustomJs != null)
            body["custom_js"] = input.CustomJs;
        if (input.ValidateMicromarkup != null)
            body["validate_micromarkup"] = input.ValidateMicromarkup;
        if (input.AllowSubdomains != null)
            body["allow_subdomains"] = input.AllowSubdomains;
        if (input.AllowedSubdomains != null)
            body["allowed_subdomains"] = input.AllowedSubdomains;
        if (input.DisallowedSubdomains != null)
            body["disallowed_subdomains"] = input.DisallowedSubdomains;
        if (input.CheckSpell != null)
            body["check_spell"] = input.CheckSpell;
        if (input.CheckSpellLanguage != null)
            body["check_spell_language"] = input.CheckSpellLanguage;
        if (input.CheckSpellExceptions != null)
            body["check_spell_exceptions"] = input.CheckSpellExceptions;
        if (input.CalculateKeywordDensity != null)
            body["calculate_keyword_density"] = input.CalculateKeywordDensity;
        if (input.ChecksThresholdJson != null)
            body["checks_threshold"] = InputValidator.Json(input.ChecksThresholdJson, "Checks threshold JSON", "object");
        if (input.DisableSitewideChecks != null)
            body["disable_sitewide_checks"] = input.DisableSitewideChecks;
        if (input.DisablePageChecks != null)
            body["disable_page_checks"] = input.DisablePageChecks;
        if (input.SwitchPool != null)
            body["switch_pool"] = input.SwitchPool;
        if (input.ReturnDespiteTimeout != null)
            body["return_despite_timeout"] = input.ReturnDespiteTimeout;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AuditsTaskPost", false);
    }

    [Action("Get audit summary", Description = "\u200c Using this function, you can get the overall information on a website as well as drill down into exact on-page issues of a website that has been scanned. As a result, you will know what functions to use for receiving d")]
    public async Task<ReportResponse<OnPageSummaryResultInfo>> AuditsSummary([ActionParameter] AuditsSummaryRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/on_page/summary/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageSummaryResultInfo>(fileManagementClient, [response], "AuditsSummary", false);
    }

    [Action("Search audit pages", Description = "This endpoint returns a list of crawled pages with on-page check-ups and other metrics related to the page performance. Using this function you will get page-specific data with detailed information on how well your pages")]
    public async Task<ReportResponse<OnPagePagesResultInfo>> AuditsPages([ActionParameter] AuditsPagesRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            if (cursor != null)
                page["search_after_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/on_page/pages", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "search_after_token");
        return await ReportWriter.Write<OnPagePagesResultInfo>(fileManagementClient, responses, "AuditsPages", true);
    }

    [Action("Search audit pages by resource", Description = "\u200c\u200c This endpoint will return the list of pages where a specific resource is located. Using this function you will also get the data related to the pages that contain a specified resource. You can get the URL of a resourc")]
    public async Task<ReportResponse<OnPagePagesByResourceResultInfo>> AuditsPagesByResource([ActionParameter] AuditsPagesByResourceRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/pages_by_resource", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPagePagesByResourceResultInfo>(fileManagementClient, responses, "AuditsPagesByResource", true);
    }

    [Action("Get audit resources", Description = "\u200c\u200c This endpoint will provide you with a list of resources, including images, scripts, stylesheets, and broken elements. You will get a detailed overview of every resource found on the crawled pages.")]
    public async Task<ReportResponse<OnPageResourcesResultInfo>> AuditsResources([ActionParameter] AuditsResourcesRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.RelevantPagesFilters != null)
            body["relevant_pages_filters"] = input.RelevantPagesFilters;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            if (cursor != null)
                page["search_after_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/on_page/resources", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "search_after_token");
        return await ReportWriter.Write<OnPageResourcesResultInfo>(fileManagementClient, responses, "AuditsResources", true);
    }

    [Action("Get audit duplicate tags", Description = "\u200c\u200c This endpoint returns a list of pages that contain duplicate title or description tags. The response also contains data related to page performance.")]
    public async Task<ReportResponse<OnPageDuplicateTagsResultInfo>> AuditsDuplicateTags([ActionParameter] AuditsDuplicateTagsRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Type, "Type");
        body["type"] = input.Type;
        if (input.Accumulator != null)
            body["accumulator"] = input.Accumulator;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/duplicate_tags", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPageDuplicateTagsResultInfo>(fileManagementClient, responses, "AuditsDuplicateTags", true);
    }

    [Action("Get audit duplicate content", Description = "\u200c\u200c This endpoint returns a list of pages that have content similar to the page specified in the request. The response also contains data related to page performance and the similarity index that indicates how similar the")]
    public async Task<ReportResponse<OnPageDuplicateContentResultInfo>> AuditsDuplicateContent([ActionParameter] AuditsDuplicateContentRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.Similarity != null)
            body["similarity"] = input.Similarity;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/duplicate_content", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPageDuplicateContentResultInfo>(fileManagementClient, responses, "AuditsDuplicateContent", true);
    }

    [Action("Search audit links", Description = "\u200c\u200c This endpoint will provide you with a list of internal and external links detected on a target website. The following link types are supported: anchor \u2013 links that point to a specific portion of a webpage; image \u2013 lin")]
    public async Task<ReportResponse<OnPageLinksResultInfo>> AuditsLinks([ActionParameter] AuditsLinksRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.PageFrom != null)
            body["page_from"] = input.PageFrom;
        if (input.PageTo != null)
            body["page_to"] = input.PageTo;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            if (cursor != null)
                page["search_after_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/on_page/links", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "search_after_token");
        return await ReportWriter.Write<OnPageLinksResultInfo>(fileManagementClient, responses, "AuditsLinks", true);
    }

    [Action("Get audit redirect chains", Description = "\u200c\u200c Redirect chains occur when there are at least two redirects between the initial URL and the destination URL. For example, if page A redirects to page B which redirects to page C, such a series of redirects is consider")]
    public async Task<ReportResponse<OnPageRedirectChainsResultInfo>> AuditsRedirectChains([ActionParameter] AuditsRedirectChainsRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/redirect_chains", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPageRedirectChainsResultInfo>(fileManagementClient, responses, "AuditsRedirectChains", true);
    }

    [Action("Get audit non indexable", Description = "\u200c\u200c This endpoint returns a list of pages that are blocked from being indexed by Google and other search engines through robots.txt, HTTP headers, or meta tags settings.")]
    public async Task<ReportResponse<OnPageNonIndexableResultInfo>> AuditsNonIndexable([ActionParameter] AuditsNonIndexableRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/non_indexable", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPageNonIndexableResultInfo>(fileManagementClient, responses, "AuditsNonIndexable", true);
    }

    [Action("Get audit waterfall", Description = "\u200c\u200c This endpoint is designed to provide you with the page speed insights. Using this function you can get detailed information about the page loading time, time to secure connection, the time it takes to load page resour")]
    public async Task<ReportResponse<OnPageWaterfallResultInfo>> AuditsWaterfall([ActionParameter] AuditsWaterfallRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/waterfall", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageWaterfallResultInfo>(fileManagementClient, [response], "AuditsWaterfall", false);
    }

    [Action("Get audit keyword density", Description = "\u200c\u200c This endpoint will provide you with keyword density and keyword frequency data for terms appearing on the specified website or web page. You can filter and sort the data that will be retrieved with this API call.")]
    public async Task<ReportResponse<OnPageKeywordDensityResultInfo>> AuditsKeywordDensity([ActionParameter] AuditsKeywordDensityRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.KeywordLength, "Keyword length");
        body["keyword_length"] = input.KeywordLength;
        if (input.Url != null)
            body["url"] = input.Url;
        if (input.Limit != null)
            body["limit"] = input.Limit;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/keyword_density", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageKeywordDensityResultInfo>(fileManagementClient, [response], "AuditsKeywordDensity", false);
    }

    [Action("Get audit microdata", Description = "\u200c\u200c This endpoint is designed to validate structured JSON-LD data and Microdata. Using this function you will obtain microdata available on the specified page of the target website and detailed results of its validation. ")]
    public async Task<ReportResponse<OnPageMicrodataResultInfo>> AuditsMicrodata([ActionParameter] AuditsMicrodataRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/microdata", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageMicrodataResultInfo>(fileManagementClient, [response], "AuditsMicrodata", false);
    }

    [Action("Get audit uncrawlable resources", Description = "\u200c\u200cThis endpoint returns a list of resources detected on the target website that could not be crawled due to a content type inconsistency. A resource is considered uncrawlable when the content type returned in the server ")]
    public async Task<ReportResponse<OnPageUncrawlableResourcesResultInfo>> AuditsUncrawlableResources([ActionParameter] AuditsUncrawlableResourcesRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/on_page/uncrawlable_resources", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<OnPageUncrawlableResourcesResultInfo>(fileManagementClient, responses, "AuditsUncrawlableResources", true);
    }

    [Action("Get audit raw HTML", Description = "\u200c\u200c This endpoint returns the HTML of a page you indicate in the request.")]
    public async Task<ReportResponse<OnPageRawHtmlResultInfo>> AuditsRawHtml([ActionParameter] AuditsRawHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/raw_html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageRawHtmlResultInfo>(fileManagementClient, [response], "AuditsRawHtml", false);
    }

    [Action("Get page screenshot", Description = "\u200c\u200c Using this endpoint, you can capture a full high-quality screenshot of any webpage. In this way, you can review the target page as the the provider crawler and Googlebot see it.")]
    public async Task<ReportResponse<OnPagePageScreenshotResultInfo>> AuditsPageScreenshot([ActionParameter] AuditsPageScreenshotRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.AcceptLanguage != null)
            body["accept_language"] = input.AcceptLanguage;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserPreset != null)
            body["browser_preset"] = input.BrowserPreset;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.FullPageScreenshot != null)
            body["full_page_screenshot"] = input.FullPageScreenshot;
        if (input.DisableCookiePopup != null)
            body["disable_cookie_popup"] = input.DisableCookiePopup;
        if (input.SwitchPool != null)
            body["switch_pool"] = input.SwitchPool;
        if (input.IpPoolForScan != null)
            body["ip_pool_for_scan"] = input.IpPoolForScan;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/page_screenshot", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPagePageScreenshotResultInfo>(fileManagementClient, [response], "AuditsPageScreenshot", false);
    }

    [Action("Get audit content parsing", Description = "\u200c\u200c This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.")]
    public async Task<ReportResponse<OnPageContentParsingResultInfo>> AuditsContentParsing([ActionParameter] AuditsContentParsingRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        InputValidator.Required(input.TaskId, "Task ID");
        body["id"] = input.TaskId;
        if (input.MarkdownView != null)
            body["markdown_view"] = input.MarkdownView;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/content_parsing", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageContentParsingResultInfo>(fileManagementClient, [response], "AuditsContentParsing", false);
    }

    [Action("Get audit content parsing report", Description = "\u200c\u200c This endpoint allows parsing the content on any page you specify and will return the structured content of the target page, including link URLs, anchors, headings, and textual content.")]
    public async Task<ReportResponse<OnPageContentParsingLiveResultInfo>> AuditsContentParsingLive([ActionParameter] AuditsContentParsingLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserPreset != null)
            body["browser_preset"] = input.BrowserPreset;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.StoreRawHtml != null)
            body["store_raw_html"] = input.StoreRawHtml;
        if (input.DisableCookiePopup != null)
            body["disable_cookie_popup"] = input.DisableCookiePopup;
        if (input.AcceptLanguage != null)
            body["accept_language"] = input.AcceptLanguage;
        if (input.EnableJavascript != null)
            body["enable_javascript"] = input.EnableJavascript;
        if (input.EnableBrowserRendering != null)
            body["enable_browser_rendering"] = input.EnableBrowserRendering;
        if (input.EnableXhr != null)
            body["enable_xhr"] = input.EnableXhr;
        if (input.SwitchPool != null)
            body["switch_pool"] = input.SwitchPool;
        if (input.IpPoolForScan != null)
            body["ip_pool_for_scan"] = input.IpPoolForScan;
        if (input.MarkdownView != null)
            body["markdown_view"] = input.MarkdownView;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/content_parsing/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageContentParsingLiveResultInfo>(fileManagementClient, [response], "AuditsContentParsingLive", false);
    }

    [Action("Search audit instant pages", Description = "Using this function you will get page-specific data with detailed information on how well a particular page is optimized for organic search. for more info please visit 'https://docs.dataforseo.com/v3/on_page/instant_page")]
    public async Task<ReportResponse<OnPageInstantPagesResultInfo>> AuditsInstantPages([ActionParameter] AuditsInstantPagesRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserPreset != null)
            body["browser_preset"] = input.BrowserPreset;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.StoreRawHtml != null)
            body["store_raw_html"] = input.StoreRawHtml;
        if (input.AcceptLanguage != null)
            body["accept_language"] = input.AcceptLanguage;
        if (input.LoadResources != null)
            body["load_resources"] = input.LoadResources;
        if (input.EnableBrowserRendering != null)
            body["enable_browser_rendering"] = input.EnableBrowserRendering;
        if (input.DisableCookiePopup != null)
            body["disable_cookie_popup"] = input.DisableCookiePopup;
        if (input.ReturnDespiteTimeout != null)
            body["return_despite_timeout"] = input.ReturnDespiteTimeout;
        if (input.EnableJavascript != null)
            body["enable_javascript"] = input.EnableJavascript;
        if (input.EnableXhr != null)
            body["enable_xhr"] = input.EnableXhr;
        if (input.CustomJs != null)
            body["custom_js"] = input.CustomJs;
        if (input.ValidateMicromarkup != null)
            body["validate_micromarkup"] = input.ValidateMicromarkup;
        if (input.CheckSpell != null)
            body["check_spell"] = input.CheckSpell;
        if (input.ChecksThresholdJson != null)
            body["checks_threshold"] = InputValidator.Json(input.ChecksThresholdJson, "Checks threshold JSON", "object");
        if (input.SwitchPool != null)
            body["switch_pool"] = input.SwitchPool;
        if (input.IpPoolForScan != null)
            body["ip_pool_for_scan"] = input.IpPoolForScan;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/instant_pages", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<OnPageInstantPagesResultInfo>(fileManagementClient, [response], "AuditsInstantPages", false);
    }

    [Action("Create audit Lighthouse task", Description = "\u200cThe OnPage Lighthouse API is based on Google\u2019s open-source Lighthouse project for measuring the quality of web pages and web apps.")]
    public async Task<ReportResponse<DynamicResult>> AuditsLighthouseTaskPost([ActionParameter] AuditsLighthouseTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.ForMobile != null)
            body["for_mobile"] = input.ForMobile;
        if (input.Categories != null)
            body["categories"] = input.Categories;
        if (input.Audits != null)
            body["audits"] = input.Audits;
        if (input.Version != null)
            body["version"] = input.Version;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.BrowserNetworkThrottlingMethod != null)
            body["browser_network_throttling_method"] = input.BrowserNetworkThrottlingMethod;
        if (input.BrowserCpuThrottlingMultiplier != null)
            body["browser_cpu_throttling_multiplier"] = input.BrowserCpuThrottlingMultiplier;
        if (input.BrowserNetworkThrottling != null)
            body["browser_network_throttling"] = input.BrowserNetworkThrottling;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/lighthouse/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AuditsLighthouseTaskPost", false);
    }

    [Action("Get audit Lighthouse results", Description = "\u200c The OnPage Lighthouse API is based on Google\u2019s open-source Lighthouse project for measuring the quality of web pages and web apps. This endpoint will provide you with the results of Lighthouse Audit. Use the id receive")]
    public async Task<ReportResponse<DynamicResult>> AuditsLighthouseTaskGetJson([ActionParameter] AuditsLighthouseTaskGetJsonRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/on_page/lighthouse/task_get/json/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AuditsLighthouseTaskGetJson", false);
    }

    [Action("Get audit Lighthouse", Description = "\u200cThe OnPage Lighthouse API is based on Google\u2019s open-source Lighthouse project for measuring the quality of web pages and web apps.")]
    public async Task<ReportResponse<DynamicResult>> AuditsLighthouseLiveJson([ActionParameter] AuditsLighthouseLiveJsonRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Url, "URL");
        body["url"] = input.Url;
        if (input.ForMobile != null)
            body["for_mobile"] = input.ForMobile;
        if (input.Categories != null)
            body["categories"] = input.Categories;
        if (input.Audits != null)
            body["audits"] = input.Audits;
        if (input.Version != null)
            body["version"] = input.Version;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.CustomUserAgent != null)
            body["custom_user_agent"] = input.CustomUserAgent;
        if (input.BrowserScreenWidth != null)
            body["browser_screen_width"] = input.BrowserScreenWidth;
        if (input.BrowserScreenHeight != null)
            body["browser_screen_height"] = input.BrowserScreenHeight;
        if (input.BrowserScreenScaleFactor != null)
            body["browser_screen_scale_factor"] = input.BrowserScreenScaleFactor;
        if (input.BrowserNetworkThrottlingMethod != null)
            body["browser_network_throttling_method"] = input.BrowserNetworkThrottlingMethod;
        if (input.BrowserCpuThrottlingMultiplier != null)
            body["browser_cpu_throttling_multiplier"] = input.BrowserCpuThrottlingMultiplier;
        if (input.BrowserNetworkThrottling != null)
            body["browser_network_throttling"] = input.BrowserNetworkThrottling;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/on_page/lighthouse/live/json", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AuditsLighthouseLiveJson", false);
    }
}
