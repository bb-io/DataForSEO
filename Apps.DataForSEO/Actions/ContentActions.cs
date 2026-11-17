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

[ActionList("Content analysis")]
public class ContentActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Search content search", Description = "\u200c This endpoint will provide you with detailed citation data available for the target keyword.")]
    public async Task<ReportResponse<ContentAnalysisSearchLiveResultInfo>> ContentSearchLive([ActionParameter] ContentSearchLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.KeywordFieldsJson != null)
            body["keyword_fields"] = InputValidator.Json(input.KeywordFieldsJson, "Keyword fields JSON", "object");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.SearchMode != null)
            body["search_mode"] = input.SearchMode;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            if (cursor != null)
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/content_analysis/search/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<ContentAnalysisSearchLiveResultInfo>(fileManagementClient, responses, "ContentSearchLive", true);
    }

    [Action("Get content summary", Description = "\u200c This endpoint will provide you with an overview of citation data available for the target keyword.")]
    public async Task<ReportResponse<ContentAnalysisSummaryInfo>> ContentContentAnalysisSummaryLive([ActionParameter] ContentContentAnalysisSummaryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.KeywordFieldsJson != null)
            body["keyword_fields"] = InputValidator.Json(input.KeywordFieldsJson, "Keyword fields JSON", "object");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.PositiveConnotationThreshold != null)
            body["positive_connotation_threshold"] = input.PositiveConnotationThreshold;
        if (input.SentimentsConnotationThreshold != null)
            body["sentiments_connotation_threshold"] = input.SentimentsConnotationThreshold;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/content_analysis/summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<ContentAnalysisSummaryInfo>(fileManagementClient, [response], "ContentContentAnalysisSummaryLive", false);
    }

    [Action("Get content sentiment analysis", Description = "This endpoint will provide you with sentiment analysis data for the citations available for the target keyword. for more info please visit 'https://docs.dataforseo.com/v3/content_analysis/sentiment_analysis/live/?bash'")]
    public async Task<ReportResponse<ContentAnalysisSentimentAnalysisLiveResultInfo>> ContentSentimentAnalysisLive([ActionParameter] ContentSentimentAnalysisLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.KeywordFieldsJson != null)
            body["keyword_fields"] = InputValidator.Json(input.KeywordFieldsJson, "Keyword fields JSON", "object");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.PositiveConnotationThreshold != null)
            body["positive_connotation_threshold"] = input.PositiveConnotationThreshold;
        if (input.SentimentsConnotationThreshold != null)
            body["sentiments_connotation_threshold"] = input.SentimentsConnotationThreshold;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/content_analysis/sentiment_analysis/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<ContentAnalysisSentimentAnalysisLiveResultInfo>(fileManagementClient, [response], "ContentSentimentAnalysisLive", false);
    }

    [Action("Get content rating distribution", Description = "\u200c This endpoint will provide you with rating distribution data for the keyword and other parameters specified in the request.")]
    public async Task<ReportResponse<ContentAnalysisRatingDistributionLiveResultInfo>> ContentRatingDistributionLive([ActionParameter] ContentRatingDistributionLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.KeywordFieldsJson != null)
            body["keyword_fields"] = InputValidator.Json(input.KeywordFieldsJson, "Keyword fields JSON", "object");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.SearchMode != null)
            body["search_mode"] = input.SearchMode;
        if (input.PositiveConnotationThreshold != null)
            body["positive_connotation_threshold"] = input.PositiveConnotationThreshold;
        if (input.SentimentsConnotationThreshold != null)
            body["sentiments_connotation_threshold"] = input.SentimentsConnotationThreshold;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/content_analysis/rating_distribution/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<ContentAnalysisRatingDistributionLiveResultInfo>(fileManagementClient, [response], "ContentRatingDistributionLive", false);
    }

    [Action("Get content phrase trends", Description = "\u200c This endpoint will provide you with data on all citations of the target keyword for the indicated date range.")]
    public async Task<ReportResponse<ContentAnalysisPhraseTrendsLiveResultInfo>> ContentPhraseTrendsLive([ActionParameter] ContentPhraseTrendsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.KeywordFieldsJson != null)
            body["keyword_fields"] = InputValidator.Json(input.KeywordFieldsJson, "Keyword fields JSON", "object");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.SearchMode != null)
            body["search_mode"] = input.SearchMode;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        InputValidator.Required(input.DateFrom, "Date from");
        body["date_from"] = input.DateFrom.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateGroup != null)
            body["date_group"] = input.DateGroup;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/content_analysis/phrase_trends/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<ContentAnalysisPhraseTrendsLiveResultInfo>(fileManagementClient, [response], "ContentPhraseTrendsLive", false);
    }

    [Action("Get content category trends", Description = "\u200c This endpoint will provide you with data on all citations in the target category for the indicated date range.")]
    public async Task<ReportResponse<ContentAnalysisCategoryTrendsLiveResultInfo>> ContentCategoryTrendsLive([ActionParameter] ContentCategoryTrendsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.CategoryCode, "Category code");
        body["category_code"] = InputValidator.Code(input.CategoryCode, "Category code");
        if (input.PageType != null)
            body["page_type"] = input.PageType;
        if (input.SearchMode != null)
            body["search_mode"] = input.SearchMode;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        InputValidator.Required(input.DateFrom, "Date from");
        body["date_from"] = input.DateFrom.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateGroup != null)
            body["date_group"] = input.DateGroup;
        if (input.InitialDatasetFiltersJson != null)
            body["initial_dataset_filters"] = InputValidator.Json(input.InitialDatasetFiltersJson, "Initial dataset filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/content_analysis/category_trends/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<ContentAnalysisCategoryTrendsLiveResultInfo>(fileManagementClient, [response], "ContentCategoryTrendsLive", false);
    }
}
