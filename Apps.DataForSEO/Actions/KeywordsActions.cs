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

[ActionList("Keyword data")]
public class KeywordsActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Create Google Ads search volume task", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider ")]
    public async Task<ReportResponse<DynamicResult>> KeywordsGoogleAdsSearchVolumeTaskPost([ActionParameter] KeywordsGoogleAdsSearchVolumeTaskPostRequest input)
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
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/search_volume/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsGoogleAdsSearchVolumeTaskPost", false);
    }

    [Action("Get Google Ads search volume results", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider ")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsSearchVolumeTaskGetResultInfo>> KeywordsGoogleAdsSearchVolumeTaskGet([ActionParameter] KeywordsGoogleAdsSearchVolumeTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/google_ads/search_volume/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsSearchVolumeTaskGetResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsSearchVolumeTaskGet", false);
    }

    [Action("Search Google Ads search volume", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider ")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsSearchVolumeLiveResultInfo>> KeywordsGoogleAdsSearchVolumeLive([ActionParameter] KeywordsGoogleAdsSearchVolumeLiveRequest input)
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
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsSearchVolumeLiveResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsSearchVolumeLive", false);
    }

    [Action("Create Google Ads keywords for site task", Description = "")]
    public async Task<ReportResponse<DynamicResult>> KeywordsGoogleAdsKeywordsForSiteTaskPost([ActionParameter] KeywordsGoogleAdsKeywordsForSiteTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.TargetType != null)
            body["target_type"] = input.TargetType;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/keywords_for_site/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForSiteTaskPost", false);
    }

    [Action("Get Google Ads keywords for site results", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider ")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResultInfo>> KeywordsGoogleAdsKeywordsForSiteTaskGet([ActionParameter] KeywordsGoogleAdsKeywordsForSiteTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/google_ads/keywords_for_site/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForSiteTaskGet", false);
    }

    [Action("Search Google Ads keywords for site", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider Go")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsKeywordsForSiteLiveResultInfo>> KeywordsGoogleAdsKeywordsForSiteLive([ActionParameter] KeywordsGoogleAdsKeywordsForSiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.TargetType != null)
            body["target_type"] = input.TargetType;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/keywords_for_site/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsKeywordsForSiteLiveResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForSiteLive", false);
    }

    [Action("Create Google Ads keyword ideas task", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider Go")]
    public async Task<ReportResponse<DynamicResult>> KeywordsGoogleAdsKeywordsForKeywordsTaskPost([ActionParameter] KeywordsGoogleAdsKeywordsForKeywordsTaskPostRequest input)
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
        if (input.Target != null)
            body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/keywords_for_keywords/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForKeywordsTaskPost", false);
    }

    [Action("Get Google Ads keyword ideas results", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider Go")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo>> KeywordsGoogleAdsKeywordsForKeywordsTaskGet([ActionParameter] KeywordsGoogleAdsKeywordsForKeywordsTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/google_ads/keywords_for_keywords/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForKeywordsTaskGet", false);
    }

    [Action("Search Google Ads keyword ideas", Description = "Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you\u2019re using the provider Google AdWords API, you need to upgrade to the provider Go")]
    public async Task<ReportResponse<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResultInfo>> KeywordsGoogleAdsKeywordsForKeywordsLive([ActionParameter] KeywordsGoogleAdsKeywordsForKeywordsLiveRequest input)
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
        if (input.LocationCoordinate != null)
            body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.IncludeAdultKeywords != null)
            body["include_adult_keywords"] = input.IncludeAdultKeywords;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_ads/keywords_for_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResultInfo>(fileManagementClient, [response], "KeywordsGoogleAdsKeywordsForKeywordsLive", false);
    }

    [Action("Create Google trends explore task", Description = "This endpoint will provide you with the keyword popularity data from the \u2018Explore\u2019 feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.")]
    public async Task<ReportResponse<DynamicResult>> KeywordsGoogleTrendsExploreTaskPost([ActionParameter] KeywordsGoogleTrendsExploreTaskPostRequest input)
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
        body["location_code"] = input.LocationCode;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Type != null)
            body["type"] = input.Type;
        InputValidator.Required(input.CategoryCode, "Category code");
        body["category_code"] = InputValidator.Code(input.CategoryCode, "Category code");
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_trends/explore/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsGoogleTrendsExploreTaskPost", false);
    }

    [Action("Get Google trends explore results", Description = "")]
    public async Task<ReportResponse<KeywordsDataGoogleTrendsExploreTaskGetResultInfo>> KeywordsGoogleTrendsExploreTaskGet([ActionParameter] KeywordsGoogleTrendsExploreTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/google_trends/explore/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleTrendsExploreTaskGetResultInfo>(fileManagementClient, [response], "KeywordsGoogleTrendsExploreTaskGet", false);
    }

    [Action("Get Google trends explore", Description = "This endpoint will provide you with the keyword popularity data from the \u2018Explore\u2019 feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.")]
    public async Task<ReportResponse<KeywordsDataGoogleTrendsExploreLiveResultInfo>> KeywordsGoogleTrendsExploreLive([ActionParameter] KeywordsGoogleTrendsExploreLiveRequest input)
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
        body["location_code"] = input.LocationCode;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Type != null)
            body["type"] = input.Type;
        InputValidator.Required(input.CategoryCode, "Category code");
        body["category_code"] = InputValidator.Code(input.CategoryCode, "Category code");
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.ItemTypes != null)
            body["item_types"] = input.ItemTypes;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/google_trends/explore/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataGoogleTrendsExploreLiveResultInfo>(fileManagementClient, [response], "KeywordsGoogleTrendsExploreLive", false);
    }

    [Action("Search search trends explore", Description = "This endpoint will provide you with the keyword popularity data from the provider Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.")]
    public async Task<ReportResponse<KeywordsDataDataForSEOTrendsExploreLiveResultInfo>> KeywordsDataForSEOTrendsExploreLive([ActionParameter] KeywordsDataForSEOTrendsExploreLiveRequest input)
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
        if (input.Type != null)
            body["type"] = input.Type;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/dataforseo_trends/explore/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataDataForSEOTrendsExploreLiveResultInfo>(fileManagementClient, [response], "KeywordsDataForSEOTrendsExploreLive", false);
    }

    [Action("Search search trends subregion interests", Description = "This endpoint will provide you with location-specific keyword popularity data from the provider Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.")]
    public async Task<ReportResponse<KeywordsDataDataForSEOTrendsSubregionInterestsLiveResultInfo>> KeywordsDataForSEOTrendsSubregionInterestsLive([ActionParameter] KeywordsDataForSEOTrendsSubregionInterestsLiveRequest input)
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
        if (input.Type != null)
            body["type"] = input.Type;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/dataforseo_trends/subregion_interests/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataDataForSEOTrendsSubregionInterestsLiveResultInfo>(fileManagementClient, [response], "KeywordsDataForSEOTrendsSubregionInterestsLive", false);
    }

    [Action("Search search trends demography", Description = "This endpoint will provide you with the demographic breakdown (by age and gender) of keyword popularity per each specified term based on the provider Trends data. You can check keyword trends for Google Search, Google News")]
    public async Task<ReportResponse<KeywordsDataDataForSEOTrendsDemographyLiveResultInfo>> KeywordsDataForSEOTrendsDemographyLive([ActionParameter] KeywordsDataForSEOTrendsDemographyLiveRequest input)
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
        if (input.Type != null)
            body["type"] = input.Type;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/dataforseo_trends/demography/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataDataForSEOTrendsDemographyLiveResultInfo>(fileManagementClient, [response], "KeywordsDataForSEOTrendsDemographyLive", false);
    }

    [Action("Search search trends merged data", Description = "This endpoint will provide you with the keyword popularity data from the provider Trends. In addition to keyword popularity rate over the given time range, you will get location-specific keyword popularity data, and a demo")]
    public async Task<ReportResponse<KeywordsDataDataForSEOTrendsMergedDataLiveResultInfo>> KeywordsDataForSEOTrendsMergedDataLive([ActionParameter] KeywordsDataForSEOTrendsMergedDataLiveRequest input)
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
        if (input.Type != null)
            body["type"] = input.Type;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.TimeRange != null)
            body["time_range"] = input.TimeRange;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/dataforseo_trends/merged_data/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataDataForSEOTrendsMergedDataLiveResultInfo>(fileManagementClient, [response], "KeywordsDataForSEOTrendsMergedDataLive", false);
    }

    [Action("Create Bing search volume task", Description = "This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values")]
    public async Task<ReportResponse<DynamicResult>> KeywordsBingSearchVolumeTaskPost([ActionParameter] KeywordsBingSearchVolumeTaskPostRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/search_volume/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsBingSearchVolumeTaskPost", false);
    }

    [Action("Get Bing search volume results", Description = "")]
    public async Task<ReportResponse<KeywordsDataBingSearchVolumeTaskGetResultInfo>> KeywordsBingSearchVolumeTaskGet([ActionParameter] KeywordsBingSearchVolumeTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/bing/search_volume/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingSearchVolumeTaskGetResultInfo>(fileManagementClient, [response], "KeywordsBingSearchVolumeTaskGet", false);
    }

    [Action("Search Bing search volume", Description = "This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values ")]
    public async Task<ReportResponse<KeywordsDataBingSearchVolumeLiveResultInfo>> KeywordsBingSearchVolumeLive([ActionParameter] KeywordsBingSearchVolumeLiveRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingSearchVolumeLiveResultInfo>(fileManagementClient, [response], "KeywordsBingSearchVolumeLive", false);
    }

    [Action("Create Bing keywords for site task", Description = "This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dyna")]
    public async Task<ReportResponse<DynamicResult>> KeywordsBingKeywordsForSiteTaskPost([ActionParameter] KeywordsBingKeywordsForSiteTaskPostRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.KeywordsNegative != null)
            body["keywords_negative"] = input.KeywordsNegative;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keywords_for_site/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsBingKeywordsForSiteTaskPost", false);
    }

    [Action("Get Bing keywords for site results", Description = "This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for the last year (for estimating search volume dynamics),")]
    public async Task<ReportResponse<KeywordsDataBingKeywordsForSiteTaskGetResultInfo>> KeywordsBingKeywordsForSiteTaskGet([ActionParameter] KeywordsBingKeywordsForSiteTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/bing/keywords_for_site/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordsForSiteTaskGetResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordsForSiteTaskGet", false);
    }

    [Action("Search Bing keywords for site", Description = "This endpoint will provide you with a list of keywords relevant to the specified URL along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics")]
    public async Task<ReportResponse<KeywordsDataBingKeywordsForSiteLiveResultInfo>> KeywordsBingKeywordsForSiteLive([ActionParameter] KeywordsBingKeywordsForSiteLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.KeywordsNegative != null)
            body["keywords_negative"] = input.KeywordsNegative;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keywords_for_site/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordsForSiteLiveResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordsForSiteLive", false);
    }

    [Action("Create Bing keyword ideas task", Description = "This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this fu")]
    public async Task<ReportResponse<DynamicResult>> KeywordsBingKeywordsForKeywordsTaskPost([ActionParameter] KeywordsBingKeywordsForKeywordsTaskPostRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.KeywordsNegative != null)
            body["keywords_negative"] = input.KeywordsNegative;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keywords_for_keywords/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsBingKeywordsForKeywordsTaskPost", false);
    }

    [Action("Get Bing keyword ideas results", Description = "This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this fun")]
    public async Task<ReportResponse<KeywordsDataBingKeywordsForKeywordsTaskGetResultInfo>> KeywordsBingKeywordsForKeywordsTaskGet([ActionParameter] KeywordsBingKeywordsForKeywordsTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/bing/keywords_for_keywords/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordsForKeywordsTaskGetResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordsForKeywordsTaskGet", false);
    }

    [Action("Search Bing keyword ideas", Description = "This endpoint will select the relevant keywords for the specified ones. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this ")]
    public async Task<ReportResponse<KeywordsDataBingKeywordsForKeywordsLiveResultInfo>> KeywordsBingKeywordsForKeywordsLive([ActionParameter] KeywordsBingKeywordsForKeywordsLiveRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.SortBy != null)
            body["sort_by"] = input.SortBy;
        if (input.KeywordsNegative != null)
            body["keywords_negative"] = input.KeywordsNegative;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.SearchPartners != null)
            body["search_partners"] = input.SearchPartners;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keywords_for_keywords/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordsForKeywordsLiveResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordsForKeywordsLive", false);
    }

    [Action("Create Bing keyword performance task", Description = "You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggreg")]
    public async Task<ReportResponse<DynamicResult>> KeywordsBingKeywordPerformanceTaskPost([ActionParameter] KeywordsBingKeywordPerformanceTaskPostRequest input)
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
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Match != null)
            body["match"] = input.Match;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keyword_performance/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsBingKeywordPerformanceTaskPost", false);
    }

    [Action("Get Bing keyword performance results", Description = "You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggreg")]
    public async Task<ReportResponse<KeywordsDataBingKeywordPerformanceTaskGetResultInfo>> KeywordsBingKeywordPerformanceTaskGet([ActionParameter] KeywordsBingKeywordPerformanceTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/bing/keyword_performance/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordPerformanceTaskGetResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordPerformanceTaskGet", false);
    }

    [Action("Get Bing keyword performance", Description = "You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggreg")]
    public async Task<ReportResponse<KeywordsDataBingKeywordPerformanceLiveResultInfo>> KeywordsBingKeywordPerformanceLive([ActionParameter] KeywordsBingKeywordPerformanceLiveRequest input)
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
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Match != null)
            body["match"] = input.Match;
        InputValidator.Required(input.LocationCode, "Location code");
        body["location_code"] = InputValidator.Code(input.LocationCode, "Location code");
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/keyword_performance/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingKeywordPerformanceLiveResultInfo>(fileManagementClient, [response], "KeywordsBingKeywordPerformanceLive", false);
    }

    [Action("Create Bing search volume history task", Description = "This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.")]
    public async Task<ReportResponse<DynamicResult>> KeywordsBingSearchVolumeHistoryTaskPost([ActionParameter] KeywordsBingSearchVolumeHistoryTaskPostRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Period != null)
            body["period"] = input.Period;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.PostbackUrl != null)
            body["postback_url"] = input.PostbackUrl;
        if (input.PingbackUrl != null)
            body["pingback_url"] = input.PingbackUrl;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/search_volume_history/task_post", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<DynamicResult>(fileManagementClient, [response], "KeywordsBingSearchVolumeHistoryTaskPost", false);
    }

    [Action("Get Bing search volume history results", Description = "")]
    public async Task<ReportResponse<KeywordsDataBingSearchVolumeHistoryTaskGetResultInfo>> KeywordsBingSearchVolumeHistoryTaskGet([ActionParameter] KeywordsBingSearchVolumeHistoryTaskGetRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TaskId, "Task ID");
        InputValidator.Validate(body);
        var request = new RestRequest($"/v3/keywords_data/bing/search_volume_history/task_get/{Uri.EscapeDataString(input.TaskId)}");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingSearchVolumeHistoryTaskGetResultInfo>(fileManagementClient, [response], "KeywordsBingSearchVolumeHistoryTaskGet", false);
    }

    [Action("Search Bing search volume history", Description = "This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.")]
    public async Task<ReportResponse<KeywordsDataBingSearchVolumeHistoryLiveResultInfo>> KeywordsBingSearchVolumeHistoryLive([ActionParameter] KeywordsBingSearchVolumeHistoryLiveRequest input)
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
        InputValidator.Required(input.LocationCoordinate, "Location coordinate");
        body["location_coordinate"] = input.LocationCoordinate;
        InputValidator.Required(input.LanguageCode, "Language code");
        body["language_code"] = input.LanguageCode;
        if (input.Device != null)
            body["device"] = input.Device;
        if (input.Period != null)
            body["period"] = input.Period;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/bing/search_volume_history/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataBingSearchVolumeHistoryLiveResultInfo>(fileManagementClient, [response], "KeywordsBingSearchVolumeHistoryLive", false);
    }

    [Action("Search clickstream search volume", Description = "")]
    public async Task<ReportResponse<KeywordsDataClickstreamDataDataForSEOSearchVolumeLiveResultInfo>> KeywordsClickstreamDataDataForSEOSearchVolumeLive([ActionParameter] KeywordsClickstreamDataDataForSEOSearchVolumeLiveRequest input)
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
        if (input.UseClickstream != null)
            body["use_clickstream"] = input.UseClickstream;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/clickstream_data/dataforseo_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataClickstreamDataDataForSEOSearchVolumeLiveResultInfo>(fileManagementClient, [response], "KeywordsClickstreamDataDataForSEOSearchVolumeLive", false);
    }

    [Action("Search clickstream global search volume", Description = "The Clickstream Global Search Volume endpoint of the provider Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What\u2019s more, it offers geogra")]
    public async Task<ReportResponse<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResultInfo>> KeywordsClickstreamDataGlobalSearchVolumeLive([ActionParameter] KeywordsClickstreamDataGlobalSearchVolumeLiveRequest input)
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
        var request = new RestRequest("/v3/keywords_data/clickstream_data/global_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResultInfo>(fileManagementClient, [response], "KeywordsClickstreamDataGlobalSearchVolumeLive", false);
    }

    [Action("Search clickstream bulk search volume", Description = "The Bulk Clickstream Search Volume endpoint of the provider Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What\u2019s more, it offers historic")]
    public async Task<ReportResponse<KeywordsDataClickstreamDataBulkSearchVolumeLiveResultInfo>> KeywordsClickstreamDataBulkSearchVolumeLive([ActionParameter] KeywordsClickstreamDataBulkSearchVolumeLiveRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/keywords_data/clickstream_data/bulk_search_volume/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<KeywordsDataClickstreamDataBulkSearchVolumeLiveResultInfo>(fileManagementClient, [response], "KeywordsClickstreamDataBulkSearchVolumeLive", false);
    }
}
