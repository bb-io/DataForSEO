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

[ActionList("Keyword and competitor research")]
public class LabsActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Get Google available history", Description = "By calling this endpoint, you will find obtain a list of dates available for setting in the first_date and second_date fields of the Domain Metrics by Categories endpoint. for more info please visit 'https://docs.datafor")]
    public async Task<ReportResponse<DataForSEOLabsGoogleAvailableHistoryResultInfo>> LabsGoogleAvailableHistory([ActionParameter] LabsGoogleAvailableHistoryRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/available_history");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleAvailableHistoryResultInfo>(fileManagementClient, [response], "LabsGoogleAvailableHistory", false);
    }

    [Action("Search Google keywords for site", Description = "\u200c The Keywords For Site endpoint will provide you with a list of keywords relevant to the target domain, subdomain, or webpage. Each keyword is supplied with relevant categories, search volume data for the last month, co")]
    public async Task<ReportResponse<DataForSEOLabsGoogleKeywordsForSiteLiveResultInfo>> LabsGoogleKeywordsForSiteLive([ActionParameter] LabsGoogleKeywordsForSiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
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
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/keywords_for_site/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<DataForSEOLabsGoogleKeywordsForSiteLiveResultInfo>(fileManagementClient, responses, "LabsGoogleKeywordsForSiteLive", true);
    }

    [Action("Search Google related keywords", Description = "The Related Keywords endpoint provides keywords appearing in the \u201cSearches Related to\u201d SERP element. View the element. You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with ")]
    public async Task<ReportResponse<DataForSEOLabsGoogleRelatedKeywordsLiveResultInfo>> LabsGoogleRelatedKeywordsLive([ActionParameter] LabsGoogleRelatedKeywordsLiveRequest input)
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
        if (input.IncludeSeedKeyword != null)
            body["include_seed_keyword"] = input.IncludeSeedKeyword;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.ReplaceWithCoreKeyword != null)
            body["replace_with_core_keyword"] = input.ReplaceWithCoreKeyword;
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
            return new RestRequest("/v3/dataforseo_labs/google/related_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleRelatedKeywordsLiveResultInfo>(fileManagementClient, responses, "LabsGoogleRelatedKeywordsLive", true);
    }

    [Action("Get Google keyword suggestions", Description = "\u200c\u200c The Keyword Suggestions endpoint provides search queries that include the specified seed keyword.")]
    public async Task<ReportResponse<DataForSEOLabsGoogleKeywordSuggestionsLiveResultInfo>> LabsGoogleKeywordSuggestionsLive([ActionParameter] LabsGoogleKeywordSuggestionsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IncludeSeedKeyword != null)
            body["include_seed_keyword"] = input.IncludeSeedKeyword;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.ExactMatch != null)
            body["exact_match"] = input.ExactMatch;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/keyword_suggestions/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<DataForSEOLabsGoogleKeywordSuggestionsLiveResultInfo>(fileManagementClient, responses, "LabsGoogleKeywordSuggestionsLive", true);
    }

    [Action("Get Google keyword ideas", Description = "\u200c The Keyword Ideas endpoint provides search terms that are relevant to the product or service categories of the specified keywords. The algorithm selects the keywords which fall into the same categories as the seed keyw")]
    public async Task<ReportResponse<DataForSEOLabsGoogleKeywordIdeasLiveResultInfo>> LabsGoogleKeywordIdeasLive([ActionParameter] LabsGoogleKeywordIdeasLiveRequest input)
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
        if (input.CloselyVariants != null)
            body["closely_variants"] = input.CloselyVariants;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
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
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/keyword_ideas/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<DataForSEOLabsGoogleKeywordIdeasLiveResultInfo>(fileManagementClient, responses, "LabsGoogleKeywordIdeasLive", true);
    }

    [Action("Get Google bulk keyword difficulty", Description = "This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results f")]
    public async Task<ReportResponse<DataForSEOLabsGoogleBulkKeywordDifficultyLiveResultInfo>> LabsGoogleBulkKeywordDifficultyLive([ActionParameter] LabsGoogleBulkKeywordDifficultyLiveRequest input)
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
        var request = new RestRequest("/v3/dataforseo_labs/google/bulk_keyword_difficulty/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleBulkKeywordDifficultyLiveResultInfo>(fileManagementClient, [response], "LabsGoogleBulkKeywordDifficultyLive", false);
    }

    [Action("Search Google search intent", Description = "\u200c This endpoint will provide you with search intent data for up to 1,000 keywords. For each keyword that you specify when setting a task, the API will return the keyword\u2019s search intent and intent probability. Besides th")]
    public async Task<ReportResponse<DataForSEOLabsGoogleSearchIntentLiveResultInfo>> LabsGoogleSearchIntentLive([ActionParameter] LabsGoogleSearchIntentLiveRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/search_intent/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleSearchIntentLiveResultInfo>(fileManagementClient, [response], "LabsGoogleSearchIntentLive", false);
    }

    [Action("Get Google categories for domain", Description = "\u200c This endpoint will provide you with Google product or service categories that include keywords the domain ranks for in search. Furthermore, you will obtain general rankings and traffic data for the keywords under a cer")]
    public async Task<ReportResponse<DataForSEOLabsGoogleCategoriesForDomainLiveResultInfo>> LabsGoogleCategoriesForDomainLive([ActionParameter] LabsGoogleCategoriesForDomainLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IncludeSubcategories != null)
            body["include_subcategories"] = input.IncludeSubcategories;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.HistoricalSerpMode != null)
            body["historical_serp_mode"] = input.HistoricalSerpMode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
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
            return new RestRequest("/v3/dataforseo_labs/google/categories_for_domain/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleCategoriesForDomainLiveResultInfo>(fileManagementClient, responses, "LabsGoogleCategoriesForDomainLive", true);
    }

    [Action("Search Google categories for keywords", Description = "This endpoint will provide you with Google product and service categories related for each specified keyword. You can indicate a maximum of 1,000 keywords in one API request.")]
    public async Task<ReportResponse<DataForSEOLabsGoogleCategoriesForKeywordsLiveResultInfo>> LabsGoogleCategoriesForKeywordsLive([ActionParameter] LabsGoogleCategoriesForKeywordsLiveRequest input)
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
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/categories_for_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleCategoriesForKeywordsLiveResultInfo>(fileManagementClient, [response], "LabsGoogleCategoriesForKeywordsLive", false);
    }

    [Action("Search Google keywords for categories", Description = "\u200c This endpoint will provide you with a list of keywords relevant to the specified product categories. You will get the search volume rate for the last month, search volume trend for the previous 12 months, as well as cu")]
    public async Task<ReportResponse<DataForSEOLabsGoogleKeywordsForCategoriesLiveResultInfo>> LabsGoogleKeywordsForCategoriesLive([ActionParameter] LabsGoogleKeywordsForCategoriesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.CategoryCodes, "Category codes");
        body["category_codes"] = input.CategoryCodes;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.CategoryIntersection != null)
            body["category_intersection"] = input.CategoryIntersection;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/keywords_for_categories/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<DataForSEOLabsGoogleKeywordsForCategoriesLiveResultInfo>(fileManagementClient, responses, "LabsGoogleKeywordsForCategoriesLive", true);
    }

    [Action("Get Google domain metrics by categories", Description = "\u200c This endpoint will provide you with dynamics of change in metrics of domains relevant to the specified product and service categories. You will receive historical ranking data from Google SERPs, along with valuable cur")]
    public async Task<ReportResponse<DataForSEOLabsGoogleDomainMetricsByCategoriesLiveResultInfo>> LabsGoogleDomainMetricsByCategoriesLive([ActionParameter] LabsGoogleDomainMetricsByCategoriesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.CategoryCodes, "Category codes");
        body["category_codes"] = input.CategoryCodes;
        InputValidator.Required(input.FirstDate, "First date");
        body["first_date"] = input.FirstDate;
        InputValidator.Required(input.SecondDate, "Second date");
        body["second_date"] = input.SecondDate;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.TopCategoriesCount != null)
            body["top_categories_count"] = input.TopCategoriesCount;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.EtvMin != null)
            body["etv_min"] = input.EtvMin;
        if (input.EtvMax != null)
            body["etv_max"] = input.EtvMax;
        if (input.Correlate != null)
            body["correlate"] = input.Correlate;
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
            return new RestRequest("/v3/dataforseo_labs/google/domain_metrics_by_categories/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleDomainMetricsByCategoriesLiveResultInfo>(fileManagementClient, responses, "LabsGoogleDomainMetricsByCategoriesLive", true);
    }

    [Action("Search Google top searches", Description = "\u200c\u200c The Top Searches endpoint of the provider Labs API can provide you with over 7 billion keywords from the the provider Keyword Database. Each keyword in the API response is provided with a set of relevant keyword data with")]
    public async Task<ReportResponse<DataForSEOLabsGoogleTopSearchesLiveResultInfo>> LabsGoogleTopSearchesLive([ActionParameter] LabsGoogleTopSearchesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
                page["offset_token"] = cursor;
            else
                page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/top_searches/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "offset_token");
        return await ReportWriter.Write<DataForSEOLabsGoogleTopSearchesLiveResultInfo>(fileManagementClient, responses, "LabsGoogleTopSearchesLive", true);
    }

    [Action("Search Google ranked keywords", Description = "\u200c This endpoint will provide you with the list of keywords that any domain, subdomain, or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as monthly searches and other dat")]
    public async Task<ReportResponse<DataForSEOLabsGoogleRankedKeywordsLiveResultInfo>> LabsGoogleRankedKeywordsLive([ActionParameter] LabsGoogleRankedKeywordsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.LoadRankAbsolute != null)
            body["load_rank_absolute"] = input.LoadRankAbsolute;
        if (input.HistoricalSerpMode != null)
            body["historical_serp_mode"] = input.HistoricalSerpMode;
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
            return new RestRequest("/v3/dataforseo_labs/google/ranked_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleRankedKeywordsLiveResultInfo>(fileManagementClient, responses, "LabsGoogleRankedKeywordsLive", true);
    }

    [Action("Search Google serp competitors", Description = "\u200c This endpoint will provide you with a list of domains ranking for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the sp")]
    public async Task<ReportResponse<DataForSEOLabsGoogleSerpCompetitorsLiveResultInfo>> LabsGoogleSerpCompetitorsLive([ActionParameter] LabsGoogleSerpCompetitorsLiveRequest input)
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
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
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
            return new RestRequest("/v3/dataforseo_labs/google/serp_competitors/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleSerpCompetitorsLiveResultInfo>(fileManagementClient, responses, "LabsGoogleSerpCompetitorsLive", true);
    }

    [Action("Search Google domain competitors", Description = "\u200c This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both compet")]
    public async Task<ReportResponse<DataForSEOLabsGoogleCompetitorsDomainLiveResultInfo>> LabsGoogleCompetitorsDomainLive([ActionParameter] LabsGoogleCompetitorsDomainLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.MaxRankGroup != null)
            body["max_rank_group"] = input.MaxRankGroup;
        if (input.ExcludeTopDomains != null)
            body["exclude_top_domains"] = input.ExcludeTopDomains;
        if (input.ExcludeDomains != null)
            body["exclude_domains"] = input.ExcludeDomains;
        if (input.IntersectingDomains != null)
            body["intersecting_domains"] = input.IntersectingDomains;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/competitors_domain/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleCompetitorsDomainLiveResultInfo>(fileManagementClient, responses, "LabsGoogleCompetitorsDomainLive", true);
    }

    [Action("Get Google domain intersection", Description = "This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get search volume, competition, cost-per-click and other data on each intersecting keyword. Along with")]
    public async Task<ReportResponse<DataForSEOLabsGoogleDomainIntersectionLiveResultInfo>> LabsGoogleDomainIntersectionLive([ActionParameter] LabsGoogleDomainIntersectionLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target1, "Target1");
        body["target1"] = input.Target1;
        InputValidator.Required(input.Target2, "Target2");
        body["target2"] = input.Target2;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Intersections != null)
            body["intersections"] = input.Intersections;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
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
            return new RestRequest("/v3/dataforseo_labs/google/domain_intersection/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleDomainIntersectionLiveResultInfo>(fileManagementClient, responses, "LabsGoogleDomainIntersectionLive", true);
    }

    [Action("Search Google subdomains", Description = "\u200c\u200c This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume")]
    public async Task<ReportResponse<DataForSEOLabsGoogleSubdomainsLiveResultInfo>> LabsGoogleSubdomainsLive([ActionParameter] LabsGoogleSubdomainsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.HistoricalSerpMode != null)
            body["historical_serp_mode"] = input.HistoricalSerpMode;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
            return new RestRequest("/v3/dataforseo_labs/google/subdomains/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleSubdomainsLiveResultInfo>(fileManagementClient, responses, "LabsGoogleSubdomainsLive", true);
    }

    [Action("Search Google relevant pages", Description = "\u200c")]
    public async Task<ReportResponse<DataForSEOLabsGoogleRelevantPagesLiveResultInfo>> LabsGoogleRelevantPagesLive([ActionParameter] LabsGoogleRelevantPagesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.HistoricalSerpMode != null)
            body["historical_serp_mode"] = input.HistoricalSerpMode;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
            return new RestRequest("/v3/dataforseo_labs/google/relevant_pages/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleRelevantPagesLiveResultInfo>(fileManagementClient, responses, "LabsGoogleRelevantPagesLive", true);
    }

    [Action("Get Google domain rank overview", Description = "\u200c This endpoint will provide you with ranking and traffic data from organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traff")]
    public async Task<ReportResponse<DataForSEOLabsGoogleDomainRankOverviewLiveResultInfo>> LabsGoogleDomainRankOverviewLive([ActionParameter] LabsGoogleDomainRankOverviewLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/google/domain_rank_overview/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGoogleDomainRankOverviewLiveResultInfo>(fileManagementClient, responses, "LabsGoogleDomainRankOverviewLive", true);
    }

    [Action("Get Google historical serps", Description = "\u200c This endpoint will provide you with Google SERPs collected within the specified time frame. You will also receive a complete overview of featured snippets and other extra elements that were present within the specified")]
    public async Task<ReportResponse<DataForSEOLabsGoogleHistoricalSerpsLiveResultInfo>> LabsGoogleHistoricalSerpsLive([ActionParameter] LabsGoogleHistoricalSerpsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Keyword, "Keyword");
        body["keyword"] = input.Keyword;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/historical_serps/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleHistoricalSerpsLiveResultInfo>(fileManagementClient, [response], "LabsGoogleHistoricalSerpsLive", false);
    }

    [Action("Get Google historical rank overview", Description = "\u200c This endpoint will provide you with historical data on rankings and traffic of the specified domain, such as domain ranking distribution in SERPs and estimated monthly traffic volume for both organic and paid results.")]
    public async Task<ReportResponse<DataForSEOLabsGoogleHistoricalRankOverviewLiveResultInfo>> LabsGoogleHistoricalRankOverviewLive([ActionParameter] LabsGoogleHistoricalRankOverviewLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.Correlate != null)
            body["correlate"] = input.Correlate;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/historical_rank_overview/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleHistoricalRankOverviewLiveResultInfo>(fileManagementClient, [response], "LabsGoogleHistoricalRankOverviewLive", false);
    }

    [Action("Get Google page intersection", Description = "This endpoint will provide you with the keywords for which specified pages rank within the same SERP. You will get search volume, competition, cost-per-click data on each intersecting keyword. Along with that, you will g")]
    public async Task<ReportResponse<DataForSEOLabsGooglePageIntersectionLiveResultInfo>> LabsGooglePageIntersectionLive([ActionParameter] LabsGooglePageIntersectionLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.PagesJson, "Pages JSON");
        body["pages"] = InputValidator.Json(input.PagesJson, "Pages JSON", "object");
        if (input.ExcludePages != null)
            body["exclude_pages"] = input.ExcludePages;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IntersectionMode != null)
            body["intersection_mode"] = input.IntersectionMode;
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
            return new RestRequest("/v3/dataforseo_labs/google/page_intersection/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsGooglePageIntersectionLiveResultInfo>(fileManagementClient, responses, "LabsGooglePageIntersectionLive", true);
    }

    [Action("Search Google historical search volume", Description = "This endpoint will provide you with Google historical search volume, current cost-per-click, and competition values for paid search, as well as SERP info. You can get historical search volume data since the beginning of ")]
    public async Task<ReportResponse<DataForSEOLabsGoogleHistoricalSearchVolumeLiveResultInfo>> LabsGoogleHistoricalSearchVolumeLive([ActionParameter] LabsGoogleHistoricalSearchVolumeLiveRequest input)
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
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/historical_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleHistoricalSearchVolumeLiveResultInfo>(fileManagementClient, [response], "LabsGoogleHistoricalSearchVolumeLive", false);
    }

    [Action("Get Google bulk traffic estimation", Description = "\u200c This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains, subdomains, or webpages. Along with organic search traffic estimations, you will also get separate values for paid search, ")]
    public async Task<ReportResponse<DataForSEOLabsGoogleBulkTrafficEstimationLiveResultInfo>> LabsGoogleBulkTrafficEstimationLive([ActionParameter] LabsGoogleBulkTrafficEstimationLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Targets != null)
            body["targets"] = input.Targets;
        if (input.TargetsFile != null)
        {
            if (input.Targets != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Supply either targets or the file, not both.");
            body["targets"] = await FileTransfer.ReadLines(fileManagementClient, input.TargetsFile);
        }
        InputValidator.Required(body.GetValueOrDefault("targets"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/bulk_traffic_estimation/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleBulkTrafficEstimationLiveResultInfo>(fileManagementClient, [response], "LabsGoogleBulkTrafficEstimationLive", false);
    }

    [Action("Get Google historical bulk traffic", Description = "\u200c This endpoint will provide you with historical monthly traffic volumes for up to 1,000 domains collected within the specified time range through October 2020. If you do not specify the range, data will be returned for ")]
    public async Task<ReportResponse<DataForSEOLabsGoogleHistoricalBulkTrafficEstimationLiveResultInfo>> LabsGoogleHistoricalBulkTrafficEstimationLive([ActionParameter] LabsGoogleHistoricalBulkTrafficEstimationLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        if (input.Targets != null)
            body["targets"] = input.Targets;
        if (input.TargetsFile != null)
        {
            if (input.Targets != null)
                throw new Blackbird.Applications.Sdk.Common.Exceptions.PluginMisconfigurationException("Supply either targets or the file, not both.");
            body["targets"] = await FileTransfer.ReadLines(fileManagementClient, input.TargetsFile);
        }
        InputValidator.Required(body.GetValueOrDefault("targets"), "Targets");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleHistoricalBulkTrafficEstimationLiveResultInfo>(fileManagementClient, [response], "LabsGoogleHistoricalBulkTrafficEstimationLive", false);
    }

    [Action("Get Google historical keyword data", Description = "\u200c\u200c This endpoint provides Google historical keyword data for specified keywords, including search volume, cost-per-click, competition values for paid search, monthly searches, and search volume trends. You can get histor")]
    public async Task<ReportResponse<DataForSEOLabsGoogleHistoricalKeywordDataLiveResultInfo>> LabsGoogleHistoricalKeywordDataLive([ActionParameter] LabsGoogleHistoricalKeywordDataLiveRequest input)
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
        var request = new RestRequest("/v3/dataforseo_labs/google/historical_keyword_data/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleHistoricalKeywordDataLiveResultInfo>(fileManagementClient, [response], "LabsGoogleHistoricalKeywordDataLive", false);
    }

    [Action("Get Google keyword overview", Description = "\u200c\u200c This endpoint provides Google keyword data for specified keywords. For each keyword, you will receive current cost-per-click, competition values for paid search, search volume, search intent, monthly searches, as well")]
    public async Task<ReportResponse<DataForSEOLabsGoogleKeywordOverviewLiveResultInfo>> LabsGoogleKeywordOverviewLive([ActionParameter] LabsGoogleKeywordOverviewLiveRequest input)
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
        if (input.IncludeSerpInfo != null)
            body["include_serp_info"] = input.IncludeSerpInfo;
        if (input.IncludeClickstreamData != null)
            body["include_clickstream_data"] = input.IncludeClickstreamData;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/google/keyword_overview/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsGoogleKeywordOverviewLiveResultInfo>(fileManagementClient, [response], "LabsGoogleKeywordOverviewLive", false);
    }

    [Action("Search Amazon bulk search volume", Description = "\u200c This endpoint will provide you with search volume values for a maximum of 1,000 keywords in one API request. Here search volume represents the approximate number of monthly searches for a keyword on Amazon. The returne")]
    public async Task<ReportResponse<DataForSEOLabsAmazonBulkSearchVolumeLiveResultInfo>> LabsAmazonBulkSearchVolumeLive([ActionParameter] LabsAmazonBulkSearchVolumeLiveRequest input)
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
        var request = new RestRequest("/v3/dataforseo_labs/amazon/bulk_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsAmazonBulkSearchVolumeLiveResultInfo>(fileManagementClient, [response], "LabsAmazonBulkSearchVolumeLive", false);
    }

    [Action("Search Amazon related keywords", Description = "\u200c\u200c The Related Keywords endpoint provides keywords appearing in the \u201cRelated Searches\u201d section on Amazon.")]
    public async Task<ReportResponse<DataForSEOLabsAmazonRelatedKeywordsLiveResultInfo>> LabsAmazonRelatedKeywordsLive([ActionParameter] LabsAmazonRelatedKeywordsLiveRequest input)
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
        if (input.IncludeSeedKeyword != null)
            body["include_seed_keyword"] = input.IncludeSeedKeyword;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/dataforseo_labs/amazon/related_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsAmazonRelatedKeywordsLiveResultInfo>(fileManagementClient, responses, "LabsAmazonRelatedKeywordsLive", true);
    }

    [Action("Search Amazon ranked keywords", Description = "\u200c This endpoint will provide you with a list of keywords the target product ranks for on Amazon. The returned results are specific to the asin specified in a POST request. Learn more about ASIN in this help center articl")]
    public async Task<ReportResponse<DataForSEOLabsAmazonRankedKeywordsLiveResultInfo>> LabsAmazonRankedKeywordsLive([ActionParameter] LabsAmazonRankedKeywordsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Asin, "Asin");
        body["asin"] = input.Asin;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IgnoreSynonyms != null)
            body["ignore_synonyms"] = input.IgnoreSynonyms;
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
            return new RestRequest("/v3/dataforseo_labs/amazon/ranked_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsAmazonRankedKeywordsLiveResultInfo>(fileManagementClient, responses, "LabsAmazonRankedKeywordsLive", true);
    }

    [Action("Get Amazon product rank overview", Description = "\u200c This endpoint will provide you with ranking data from organic and paid Amazon SERPs for the target products. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this hel")]
    public async Task<ReportResponse<DataForSEOLabsAmazonProductRankOverviewLiveResultInfo>> LabsAmazonProductRankOverviewLive([ActionParameter] LabsAmazonProductRankOverviewLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Asins, "Asins");
        body["asins"] = input.Asins;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/dataforseo_labs/amazon/product_rank_overview/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DataForSEOLabsAmazonProductRankOverviewLiveResultInfo>(fileManagementClient, [response], "LabsAmazonProductRankOverviewLive", false);
    }

    [Action("Search Amazon product competitors", Description = "\u200c This endpoint will provide you with a list of products that intersect with a target asin in Amazon SERPs. The data can help you identify product competitors for any listing published on Amazon. The returned results are")]
    public async Task<ReportResponse<DataForSEOLabsAmazonProductCompetitorsLiveResultInfo>> LabsAmazonProductCompetitorsLive([ActionParameter] LabsAmazonProductCompetitorsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Asin, "Asin");
        body["asin"] = input.Asin;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
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
            return new RestRequest("/v3/dataforseo_labs/amazon/product_competitors/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsAmazonProductCompetitorsLiveResultInfo>(fileManagementClient, responses, "LabsAmazonProductCompetitorsLive", true);
    }

    [Action("Get Amazon product keyword intersections", Description = "\u200c This endpoint will provide you with a list of keywords for which the target products intersect in Amazon SERP. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this h")]
    public async Task<ReportResponse<DataForSEOLabsAmazonProductKeywordIntersectionsLiveResultInfo>> LabsAmazonProductKeywordIntersectionsLive([ActionParameter] LabsAmazonProductKeywordIntersectionsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.AsinsJson, "Asins JSON");
        body["asins"] = InputValidator.Json(input.AsinsJson, "Asins JSON", "object");
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.IntersectionMode != null)
            body["intersection_mode"] = input.IntersectionMode;
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
            return new RestRequest("/v3/dataforseo_labs/amazon/product_keyword_intersections/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<DataForSEOLabsAmazonProductKeywordIntersectionsLiveResultInfo>(fileManagementClient, responses, "LabsAmazonProductKeywordIntersectionsLive", true);
    }
}
