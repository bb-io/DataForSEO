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

[ActionList("AI visibility")]
public class AiVisibilityActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Create ChatGPT AI search task", Description = "ChatGPT LLM Scraper API provides results from ChatGPT searches. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.")]
    public async Task<ReportResponse<DynamicResult>> AiVisibilityChatGptLlmScraperTaskPost([ActionParameter] AiVisibilityChatGptLlmScraperTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.Priority != null)
            body["priority"] = InputValidator.Code(input.Priority, "Priority");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ForceWebSearch != null)
            body["force_web_search"] = input.ForceWebSearch;
        if (input.ExpandCitations != null)
            body["expand_citations"] = input.ExpandCitations;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PostbackUrl != null)
            InputValidator.Required(input.PostbackData, "Postback data");
        if (input.PostbackData != null)
            body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/chat_gpt/llm_scraper/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AiVisibilityChatGptLlmScraperTaskPost", false);
    }

    [Action("Get ChatGPT AI search results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<AiOptimizationChatGptLlmScraperTaskGetAdvancedResultInfo>> AiVisibilityChatGptLlmScraperTaskGetAdvanced([ActionParameter] AiVisibilityChatGptLlmScraperTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/ai_optimization/chat_gpt/llm_scraper/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationChatGptLlmScraperTaskGetAdvancedResultInfo>(fileManagementClient, [response], "AiVisibilityChatGptLlmScraperTaskGetAdvanced", false);
    }

    [Action("Get ChatGPT AI search HTML results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<AiOptimizationChatGptLlmScraperTaskGetHtmlResultInfo>> AiVisibilityChatGptLlmScraperTaskGetHtml([ActionParameter] AiVisibilityChatGptLlmScraperTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/ai_optimization/chat_gpt/llm_scraper/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationChatGptLlmScraperTaskGetHtmlResultInfo>(fileManagementClient, [response], "AiVisibilityChatGptLlmScraperTaskGetHtml", false);
    }

    [Action("Search ChatGPT AI search", Description = "Live ChatGPT LLM Scraper endpoint provides results from ChatGPT searches. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) parameters.")]
    public async Task<ReportResponse<AiOptimizationChatGptLlmScraperLiveAdvancedResultInfo>> AiVisibilityChatGptLlmScraperLiveAdvanced([ActionParameter] AiVisibilityChatGptLlmScraperLiveAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ForceWebSearch != null)
            body["force_web_search"] = input.ForceWebSearch;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/chat_gpt/llm_scraper/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationChatGptLlmScraperLiveAdvancedResultInfo>(fileManagementClient, [response], "AiVisibilityChatGptLlmScraperLiveAdvanced", false);
    }

    [Action("Search ChatGPT AI search HTML", Description = "Live ChatGPT LLM Scraper API HTML provides a raw HTML page of the results for the specified keyword, language, and location.")]
    public async Task<ReportResponse<AiOptimizationChatGptLlmScraperLiveHtmlResultInfo>> AiVisibilityChatGptLlmScraperLiveHtml([ActionParameter] AiVisibilityChatGptLlmScraperLiveHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ForceWebSearch != null)
            body["force_web_search"] = input.ForceWebSearch;
        if (input.ExpandCitations != null)
            body["expand_citations"] = input.ExpandCitations;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/chat_gpt/llm_scraper/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationChatGptLlmScraperLiveHtmlResultInfo>(fileManagementClient, [response], "AiVisibilityChatGptLlmScraperLiveHtml", false);
    }

    [Action("Create Gemini AI search task", Description = "Gemini LLM Scraper API provides structured results from Gemini. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages), and keyword.")]
    public async Task<ReportResponse<DynamicResult>> AiVisibilityGeminiLlmScraperTaskPost([ActionParameter] AiVisibilityGeminiLlmScraperTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
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
        if (input.ExpandCitations != null)
            body["expand_citations"] = input.ExpandCitations;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PostbackUrl != null)
            InputValidator.Required(input.PostbackData, "Postback data");
        if (input.PostbackData != null)
            body["postback_data"] = input.PostbackData;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/gemini/llm_scraper/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "AiVisibilityGeminiLlmScraperTaskPost", false);
    }

    [Action("Get Gemini AI search results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<AiOptimizationGeminiLlmScraperTaskGetAdvancedResultInfo>> AiVisibilityGeminiLlmScraperTaskGetAdvanced([ActionParameter] AiVisibilityGeminiLlmScraperTaskGetAdvancedRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/ai_optimization/gemini/llm_scraper/task_get/advanced/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationGeminiLlmScraperTaskGetAdvancedResultInfo>(fileManagementClient, [response], "AiVisibilityGeminiLlmScraperTaskGetAdvanced", false);
    }

    [Action("Get Gemini AI search HTML results", Description = "Description of the fields for sending a request:")]
    public async Task<ReportResponse<AiOptimizationGeminiLlmScraperTaskGetHtmlResultInfo>> AiVisibilityGeminiLlmScraperTaskGetHtml([ActionParameter] AiVisibilityGeminiLlmScraperTaskGetHtmlRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/ai_optimization/gemini/llm_scraper/task_get/html/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationGeminiLlmScraperTaskGetHtmlResultInfo>(fileManagementClient, [response], "AiVisibilityGeminiLlmScraperTaskGetHtml", false);
    }

    [Action("Search Gemini AI search", Description = "Live Gemini LLM Scraper endpoint provides structured results from Gemini. The results are specific to the selected location (see the List of Locations), language (see the List of Languages), and keyword.")]
    public async Task<ReportResponse<AiOptimizationGeminiLlmScraperLiveAdvancedResultInfo>> AiVisibilityGeminiLlmScraperLiveAdvanced([ActionParameter] AiVisibilityGeminiLlmScraperLiveAdvancedRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/gemini/llm_scraper/live/advanced", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationGeminiLlmScraperLiveAdvancedResultInfo>(fileManagementClient, [response], "AiVisibilityGeminiLlmScraperLiveAdvanced", false);
    }

    [Action("Search Gemini AI search HTML", Description = "Live Gemini LLM Scraper API HTML provides a raw HTML page of the results for the specified keyword, language (see the List of Languages), and location (see the List of Locations).")]
    public async Task<ReportResponse<AiOptimizationGeminiLlmScraperLiveHtmlResultInfo>> AiVisibilityGeminiLlmScraperLiveHtml([ActionParameter] AiVisibilityGeminiLlmScraperLiveHtmlRequest input)
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
        if (input.ExpandCitations != null)
            body["expand_citations"] = input.ExpandCitations;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/gemini/llm_scraper/live/html", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationGeminiLlmScraperLiveHtmlResultInfo>(fileManagementClient, [response], "AiVisibilityGeminiLlmScraperLiveHtml", false);
    }

    [Action("Search AI search volume", Description = "This endpoint provides search volume data for your target keywords, reflecting their estimated usage in AI tools.")]
    public async Task<ReportResponse<AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveResultInfo>> AiVisibilityAiKeywordDataKeywordsSearchVolumeLive([ActionParameter] AiVisibilityAiKeywordDataKeywordsSearchVolumeLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Keywords != null)
            body["keywords"] = input.Keywords;
        if (input.KeywordsFile != null)
        {
            if (input.Keywords != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Supply either keywords or the file, not both.");
            body["keywords"] = await FileTransfer.ReadLines(fileManagementClient, input.KeywordsFile);
        }
        InputValidator.Required(body.GetValueOrDefault("keywords"), "Keywords");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/ai_keyword_data/keywords_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveResultInfo>(fileManagementClient, [response], "AiVisibilityAiKeywordDataKeywordsSearchVolumeLive", false);
    }

    [Action("Search AI mentions search mentions", Description = "Live LLM Mentions Search endpoint provides mention data and related metrics from AI searches. The results are specific to the selected platform (google for Google\u2019s AI Overview or chat_gpt for ChatGPT), as well as loc")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsSearchMentionsLiveResultInfo>> AiVisibilityLlmMentionsSearchMentionsLive([ActionParameter] AiVisibilityLlmMentionsSearchMentionsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
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
            return new RestRequest("/v3/ai_optimization/llm_mentions/search_mentions/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "search_after_token");
        return await ReportWriter.Write<AiOptimizationLlmMentionsSearchMentionsLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsSearchMentionsLive", true);
    }

    [Action("Search AI mentions target metrics", Description = "Live LLM Mentions Target Metrics endpoint provides aggregated metrics for mentions of the keywords or domains specified in the target array of the request. The results are specific to the selected platform (google for")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTargetMetricsLiveResultInfo>> AiVisibilityLlmMentionsTargetMetricsLive([ActionParameter] AiVisibilityLlmMentionsTargetMetricsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/llm_mentions/target_metrics/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTargetMetricsLiveResultInfo>(fileManagementClient, [response], "AiVisibilityLlmMentionsTargetMetricsLive", false);
    }

    [Action("Search AI mentions multi target metrics", Description = "Live LLM Mentions Multi-Target Metrics endpoint provides aggregated metrics grouped by custom keys for mentions of the keywords or domains specified in the target array of the request. Each item in the results array c")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsMultiTargetMetricsLiveResultInfo>> AiVisibilityLlmMentionsMultiTargetMetricsLive([ActionParameter] AiVisibilityLlmMentionsMultiTargetMetricsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetsJson != null)
            body["targets"] = InputValidator.Json(input.TargetsJson, "Targets JSON", "array");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/multi_target_metrics/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsMultiTargetMetricsLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsMultiTargetMetricsLive", true);
    }

    [Action("Search AI mentions top domains", Description = "Live LLM Mentions Top Mentioned Domains endpoint provides aggregated LLM mentions metrics grouped by the most frequently mentioned domains for the specified target. The results are specific to the selected platform (g")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedDomainsLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedDomainsLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedDomainsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.LinksScope != null)
            body["links_scope"] = input.LinksScope;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeDomains != null)
            body["include_domains"] = input.IncludeDomains;
        if (input.ExcludeDomains != null)
            body["exclude_domains"] = input.ExcludeDomains;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_domains/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedDomainsLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedDomainsLive", true);
    }

    [Action("Search AI mentions top pages", Description = "Live LLM Mentions Top Mentioned Pages endpoint provides aggregated LLM mentions metrics grouped by the most frequently mentioned pages for the specified target. The results are specific to the selected platform (googl")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedPagesLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedPagesLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedPagesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.LinksScope != null)
            body["links_scope"] = input.LinksScope;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludePages != null)
            body["include_pages"] = input.IncludePages;
        if (input.ExcludePages != null)
            body["exclude_pages"] = input.ExcludePages;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_pages/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedPagesLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedPagesLive", true);
    }

    [Action("Search AI mentions top brands", Description = "Live LLM Mentions Top Mentioned Brands endpoint provides aggregated LLM mentions metrics grouped by the most frequently mentioned brands for the specified target. The results are specific to the selected platform, loc")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedBrandsLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedBrandsLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedBrandsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeBrands != null)
            body["include_brands"] = input.IncludeBrands;
        if (input.ExcludeBrands != null)
            body["exclude_brands"] = input.ExcludeBrands;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_brands/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedBrandsLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedBrandsLive", true);
    }

    [Action("Search AI mentions top brand categories", Description = "Live LLM Mentions Top Mentioned Brand Categories endpoint provides aggregated LLM mentions metrics grouped by the most frequently mentioned brand categories for the specified target. The results are specific to the se")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedBrandCategoriesLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeBrandCategories != null)
            body["include_brand_categories"] = input.IncludeBrandCategories;
        if (input.ExcludeBrandCategories != null)
            body["exclude_brand_categories"] = input.ExcludeBrandCategories;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_brand_categories/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedBrandCategoriesLive", true);
    }

    [Action("Search AI mentions target metrics lite", Description = "Live LLM Mentions Target Metrics Lite endpoint is the simplified version of the Target Metrics endpoint and provides a simplified view of aggregated LLM mentions for keywords and domains specified in the target array of ")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTargetMetricsLiteLiveResultInfo>> AiVisibilityLlmMentionsTargetMetricsLiteLive([ActionParameter] AiVisibilityLlmMentionsTargetMetricsLiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/target_metrics_lite/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTargetMetricsLiteLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTargetMetricsLiteLive", true);
    }

    [Action("Search AI mentions top domains lite", Description = "Live LLM Mentions Top Mentioned Domains Lite endpoint is the simplified version of the Top Mentioned Domains endpoint and provides a simplified view of aggregated LLM mentions metrics grouped by the most frequently me")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedDomainsLiteLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedDomainsLiteLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedDomainsLiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.LinksScope != null)
            body["links_scope"] = input.LinksScope;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeDomains != null)
            body["include_domains"] = input.IncludeDomains;
        if (input.ExcludeDomains != null)
            body["exclude_domains"] = input.ExcludeDomains;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_domains_lite/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedDomainsLiteLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedDomainsLiteLive", true);
    }

    [Action("Search AI mentions top pages lite", Description = "Live LLM Mentions Top Mentioned Pages Lite endpoint is a simplified version of the Top Mentioned Pages that provides a simplified view of aggregated LLM mentions metrics grouped by the most frequently mentioned pages ")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedPagesLiteLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedPagesLiteLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedPagesLiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.LinksScope != null)
            body["links_scope"] = input.LinksScope;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludePages != null)
            body["include_pages"] = input.IncludePages;
        if (input.ExcludePages != null)
            body["exclude_pages"] = input.ExcludePages;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_pages_lite/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedPagesLiteLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedPagesLiteLive", true);
    }

    [Action("Search AI mentions top brands lite", Description = "Live LLM Mentions Top Mentioned Brands Lite endpoint is the simplified version of the Top Mentioned Brands endpoint and provides a simplified view of aggregated LLM mentions metrics grouped by the most frequently ment")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedBrandsLiteLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedBrandsLiteLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeBrands != null)
            body["include_brands"] = input.IncludeBrands;
        if (input.ExcludeBrands != null)
            body["exclude_brands"] = input.ExcludeBrands;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_brands_lite/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedBrandsLiteLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedBrandsLiteLive", true);
    }

    [Action("Search AI brand categories lite", Description = "Live LLM Mentions Top Mentioned Brand Categories Lite endpoint is the simplified version of the Top Mentioned Brand Categories endpoint and provides a simplified view of aggregated LLM mentions metrics grouped by the ")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiteLiveResultInfo>> AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiteLive([ActionParameter] AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.IncludeBrandCategories != null)
            body["include_brand_categories"] = input.IncludeBrandCategories;
        if (input.ExcludeBrandCategories != null)
            body["exclude_brand_categories"] = input.ExcludeBrandCategories;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/ai_optimization/llm_mentions/top_mentioned_brand_categories_lite/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiteLiveResultInfo>(fileManagementClient, responses, "AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiteLive", true);
    }

    [Action("Search AI mentions historical", Description = "Live LLM Mentions Historical endpoint provides month-by-month historical metrics for mentions of the keywords or domains specified in the target array of the request. For each month, the response returns the total men")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsHistoricalLiveResultInfo>> AiVisibilityLlmMentionsHistoricalLive([ActionParameter] AiVisibilityLlmMentionsHistoricalLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/llm_mentions/historical/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationLlmMentionsHistoricalLiveResultInfo>(fileManagementClient, [response], "AiVisibilityLlmMentionsHistoricalLive", false);
    }

    [Action("Search AI mentions timeseries delta", Description = "The Live LLM Mentions Timeseries Delta endpoint provides the difference in historical mentions and AI search volume data between two specified dates. The results are specific to the specified target (keyword or domain")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTimeseriesDeltaLiveResultInfo>> AiVisibilityLlmMentionsTimeseriesDeltaLive([ActionParameter] AiVisibilityLlmMentionsTimeseriesDeltaLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.DateFrom, "Date from");
        body["date_from"] = input.DateFrom.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.DateTo, "Date to");
        body["date_to"] = input.DateTo.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.GroupRange, "Group range");
        body["group_range"] = input.GroupRange;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/llm_mentions/timeseries_delta/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTimeseriesDeltaLiveResultInfo>(fileManagementClient, [response], "AiVisibilityLlmMentionsTimeseriesDeltaLive", false);
    }

    [Action("Search AI mentions timeseries new lost", Description = "This endpoint will provide you with the number of new and lost LLM mentions, as well as ai_search_volume for the domain or keyword specified in the target field.")]
    public async Task<ReportResponse<AiOptimizationLlmMentionsTimeseriesNewLostLiveResultInfo>> AiVisibilityLlmMentionsTimeseriesNewLostLive([ActionParameter] AiVisibilityLlmMentionsTimeseriesNewLostLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.TargetJson != null)
            body["target"] = InputValidator.Json(input.TargetJson, "Target JSON", "array");
        if (input.TargetDomains != null || input.TargetKeywords != null)
        {
            if (input.TargetJson != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Use target collections or Target JSON, not both.");
            body["target"] = (input.TargetDomains ?? []).Select(x => (object)new { domain = x }).Concat((input.TargetKeywords ?? []).Select(x => (object)new { keyword = x })).ToArray();
        }
        InputValidator.Required(body.GetValueOrDefault("target"), "Targets");
        InputValidator.Required(input.DateFrom, "Date from");
        body["date_from"] = input.DateFrom.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.DateTo, "Date to");
        body["date_to"] = input.DateTo.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.GroupRange, "Group range");
        body["group_range"] = input.GroupRange;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Platform != null)
            body["platform"] = input.Platform;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/ai_optimization/llm_mentions/timeseries_new_lost/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AiOptimizationLlmMentionsTimeseriesNewLostLiveResultInfo>(fileManagementClient, [response], "AiVisibilityLlmMentionsTimeseriesNewLostLive", false);
    }
}
