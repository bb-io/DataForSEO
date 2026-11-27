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

[ActionList("Backlinks")]
public class BacklinksActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Get backlink index", Description = "This endpoint will provide you with the total number of backlinks, domains, and pages our database contains for the moment when you make a request. You will also get stats for the last 12 months.")]
    public async Task<ReportResponse<BacklinksIndexResultInfo>> BacklinksIndex([ActionParameter] BacklinksIndexRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/index");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksIndexResultInfo>(fileManagementClient, [response], "BacklinksIndex", false);
    }

    [Action("Get backlink summary", Description = "This endpoint will provide you with an overview of backlinks data available for a given domain, subdomain, or webpage.")]
    public async Task<ReportResponse<BacklinksSummaryLiveResultInfo>> BacklinksSummaryLive([ActionParameter] BacklinksSummaryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksSummaryLiveResultInfo>(fileManagementClient, [response], "BacklinksSummaryLive", false);
    }

    [Action("Get backlink history", Description = "This endpoint will provide you with historical backlinks data back to the beginning of 2019. You can receive the number of backlinks a given domain had in a specific time period, the number of new & lost backlinks, ref")]
    public async Task<ReportResponse<BacklinksHistoryLiveResultInfo>> BacklinksHistoryLive([ActionParameter] BacklinksHistoryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/history/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksHistoryLiveResultInfo>(fileManagementClient, [response], "BacklinksHistoryLive", false);
    }

    [Action("Search backlinks", Description = "This endpoint will provide you with a list of backlinks and relevant data for the specified domain, subdomain, or webpage.")]
    public async Task<ReportResponse<BacklinksBacklinksLiveResultInfo>> BacklinksBacklinksLive([ActionParameter] BacklinksBacklinksLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.Mode != null)
            body["mode"] = input.Mode;
        if (input.CustomModeJson != null)
            body["custom_mode"] = InputValidator.Json(input.CustomModeJson, "Custom mode JSON", "object");
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
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
            return new RestRequest("/v3/backlinks/backlinks/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, "search_after_token");
        return await ReportWriter.Write<BacklinksBacklinksLiveResultInfo>(fileManagementClient, responses, "BacklinksBacklinksLive", true);
    }

    [Action("Search backlink anchors", Description = "This endpoint will provide you with a detailed overview of anchors used when linking to the specified website with relevant backlink data for each of them.")]
    public async Task<ReportResponse<BacklinksAnchorsLiveResultInfo>> BacklinksAnchorsLive([ActionParameter] BacklinksAnchorsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/anchors/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksAnchorsLiveResultInfo>(fileManagementClient, responses, "BacklinksAnchorsLive", true);
    }

    [Action("Search backlink domain pages", Description = "This endpoint will provide you with a detailed overview of domain pages with backlink data for each page.")]
    public async Task<ReportResponse<BacklinksDomainPagesLiveResultInfo>> BacklinksDomainPagesLive([ActionParameter] BacklinksDomainPagesLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/domain_pages/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksDomainPagesLiveResultInfo>(fileManagementClient, responses, "BacklinksDomainPagesLive", true);
    }

    [Action("Search backlink domain pages summary", Description = "This endpoint will provide you with detailed summary data on all backlinks and related metrics for each page of the target domain or subdomain you specify. If you indicate a single page as a target, you will get comprehe")]
    public async Task<ReportResponse<BacklinksDomainPagesSummaryLiveResultInfo>> BacklinksDomainPagesSummaryLive([ActionParameter] BacklinksDomainPagesSummaryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/domain_pages_summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksDomainPagesSummaryLiveResultInfo>(fileManagementClient, responses, "BacklinksDomainPagesSummaryLive", true);
    }

    [Action("Search backlink referring domains", Description = "This endpoint will provide you with a detailed overview of referring domains pointing to the target you specify.")]
    public async Task<ReportResponse<BacklinksReferringDomainsLiveResultInfo>> BacklinksReferringDomainsLive([ActionParameter] BacklinksReferringDomainsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/referring_domains/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksReferringDomainsLiveResultInfo>(fileManagementClient, responses, "BacklinksReferringDomainsLive", true);
    }

    [Action("Get backlink referring networks", Description = "This endpoint will provide you with a detailed overview of referring IPs and subnets pointing to the target you specify.")]
    public async Task<ReportResponse<BacklinksReferringNetworksLiveResultInfo>> BacklinksReferringNetworksLive([ActionParameter] BacklinksReferringNetworksLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.NetworkAddressType != null)
            body["network_address_type"] = input.NetworkAddressType;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/referring_networks/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksReferringNetworksLiveResultInfo>(fileManagementClient, responses, "BacklinksReferringNetworksLive", true);
    }

    [Action("Search backlink competitors", Description = "This endpoint will provide you with a list of competitors that share some part of the backlink profile with a target website, along with a number of backlink intersections and the rank of every competing website.")]
    public async Task<ReportResponse<BacklinksCompetitorsLiveResultInfo>> BacklinksCompetitorsLive([ActionParameter] BacklinksCompetitorsLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.MainDomain != null)
            body["main_domain"] = input.MainDomain;
        if (input.ExcludeLargeDomains != null)
            body["exclude_large_domains"] = input.ExcludeLargeDomains;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/competitors/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksCompetitorsLiveResultInfo>(fileManagementClient, responses, "BacklinksCompetitorsLive", true);
    }

    [Action("Get backlink domain intersection", Description = "This endpoint will provide you with the list of domains pointing to the specified websites. This endpoint is especially useful for creating a Link Gap feature that shows what domains link to your competitors but do not")]
    public async Task<ReportResponse<BacklinksDomainIntersectionLiveResultInfo>> BacklinksDomainIntersectionLive([ActionParameter] BacklinksDomainIntersectionLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TargetsJson, "Targets JSON");
        body["targets"] = InputValidator.Json(input.TargetsJson, "Targets JSON", "object");
        if (input.ExcludeTargets != null)
            body["exclude_targets"] = input.ExcludeTargets;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.BacklinksFiltersJson != null)
            body["backlinks_filters"] = InputValidator.Json(input.BacklinksFiltersJson, "Backlinks filters JSON", "array");
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.IntersectionMode != null)
            body["intersection_mode"] = input.IntersectionMode;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/domain_intersection/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksDomainIntersectionLiveResultInfo>(fileManagementClient, responses, "BacklinksDomainIntersectionLive", true);
    }

    [Action("Get backlink page intersection", Description = "This endpoint will provide you with the list of referring pages pointing to the specified targets. It is especially useful for finding the backlinks that point to your competitors but don\u2019t point to your website.")]
    public async Task<ReportResponse<BacklinksPageIntersectionLiveResultInfo>> BacklinksPageIntersectionLive([ActionParameter] BacklinksPageIntersectionLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.TargetsJson, "Targets JSON");
        body["targets"] = InputValidator.Json(input.TargetsJson, "Targets JSON", "object");
        if (input.ExcludeTargets != null)
            body["exclude_targets"] = input.ExcludeTargets;
        if (input.BacklinksStatusType != null)
            body["backlinks_status_type"] = input.BacklinksStatusType;
        if (input.FiltersJson != null)
            body["filters"] = InputValidator.Json(input.FiltersJson, "Filters JSON", "array");
        if (input.OrderBy != null)
            body["order_by"] = input.OrderBy;
        if (input.InternalListLimit != null)
            body["internal_list_limit"] = input.InternalListLimit;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.IncludeIndirectLinks != null)
            body["include_indirect_links"] = input.IncludeIndirectLinks;
        if (input.ExcludeInternalBacklinks != null)
            body["exclude_internal_backlinks"] = input.ExcludeInternalBacklinks;
        if (input.IntersectionMode != null)
            body["intersection_mode"] = input.IntersectionMode;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var responses = await Client.Paginate((offset, size, cursor) =>
        {
            var page = new Dictionary<string, object>(body) { ["limit"] = size };
            page["offset"] = offset;
            return new RestRequest("/v3/backlinks/page_intersection/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { page }), DataFormat.Json);
        }, input.MaximumResults ?? 100, null);
        return await ReportWriter.Write<BacklinksPageIntersectionLiveResultInfo>(fileManagementClient, responses, "BacklinksPageIntersectionLive", true);
    }

    [Action("Get backlink timeseries summary", Description = "This endpoint will provide you with an overview of backlink data for the target domain available during a period between the two indicated dates. Backlink metrics will be grouped by the time range that you define: day,")]
    public async Task<ReportResponse<BacklinksTimeseriesSummaryLiveResultInfo>> BacklinksTimeseriesSummaryLive([ActionParameter] BacklinksTimeseriesSummaryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.GroupRange != null)
            body["group_range"] = input.GroupRange;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/timeseries_summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksTimeseriesSummaryLiveResultInfo>(fileManagementClient, [response], "BacklinksTimeseriesSummaryLive", false);
    }

    [Action("Get backlink timeseries new lost summary", Description = "This endpoint will provide you with the number of new and lost backlinks and referring domains for the domain specified in the target field.")]
    public async Task<ReportResponse<BacklinksTimeseriesNewLostSummaryLiveResultInfo>> BacklinksTimeseriesNewLostSummaryLive([ActionParameter] BacklinksTimeseriesNewLostSummaryLiveRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Required(input.Target, "Target");
        body["target"] = input.Target;
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.DateTo != null)
            body["date_to"] = input.DateTo.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.GroupRange != null)
            body["group_range"] = input.GroupRange;
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/timeseries_new_lost_summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksTimeseriesNewLostSummaryLiveResultInfo>(fileManagementClient, [response], "BacklinksTimeseriesNewLostSummaryLive", false);
    }

    [Action("Get backlink bulk ranks", Description = "This endpoint will provide you with rank scores of the domains, subdomains, and pages specified in the targets array. The score is based on the number of referring domains pointing to the specified domains, subdomains,")]
    public async Task<ReportResponse<BacklinksBulkRanksLiveResultInfo>> BacklinksBulkRanksLive([ActionParameter] BacklinksBulkRanksLiveRequest input)
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
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_ranks/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkRanksLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkRanksLive", false);
    }

    [Action("Search backlink bulk backlinks", Description = "This endpoint will provide you with the number of backlinks pointing to domains, subdomains, and pages specified in the targets array. The returned numbers correspond to all live backlinks, that is, total number of ref")]
    public async Task<ReportResponse<BacklinksBulkBacklinksLiveResultInfo>> BacklinksBulkBacklinksLive([ActionParameter] BacklinksBulkBacklinksLiveRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_backlinks/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkBacklinksLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkBacklinksLive", false);
    }

    [Action("Get backlink bulk spam score", Description = "This endpoint will provide you with spam scores of the domains, subdomains, and pages you specified in the targets array. Spam Score is the provider\u2019s proprietary metric that indicates how \u201cspammy\u201d your target is on a sc")]
    public async Task<ReportResponse<BacklinksBulkSpamScoreLiveResultInfo>> BacklinksBulkSpamScoreLive([ActionParameter] BacklinksBulkSpamScoreLiveRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_spam_score/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkSpamScoreLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkSpamScoreLive", false);
    }

    [Action("Search backlink bulk referring domains", Description = "This endpoint will provide you with the number of referring domains pointing to domains, subdomains, and pages specified in the targets array. The returned numbers are based on all live referring domains, that is, tota")]
    public async Task<ReportResponse<BacklinksBulkReferringDomainsLiveResultInfo>> BacklinksBulkReferringDomainsLive([ActionParameter] BacklinksBulkReferringDomainsLiveRequest input)
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
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_referring_domains/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkReferringDomainsLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkReferringDomainsLive", false);
    }

    [Action("Search backlink bulk new lost backlinks", Description = "This endpoint will provide you with the number of new and lost backlinks for the domains, subdomains, and pages specified in the targets array.")]
    public async Task<ReportResponse<BacklinksBulkNewLostBacklinksLiveResultInfo>> BacklinksBulkNewLostBacklinksLive([ActionParameter] BacklinksBulkNewLostBacklinksLiveRequest input)
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
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_new_lost_backlinks/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkNewLostBacklinksLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkNewLostBacklinksLive", false);
    }

    [Action("Search new/lost referring domains", Description = "This endpoint will provide you with the number of referring domains pointing to the domains, subdomains and pages specified in the targets array.")]
    public async Task<ReportResponse<BacklinksBulkNewLostReferringDomainsLiveResultInfo>> BacklinksBulkNewLostReferringDomainsLive([ActionParameter] BacklinksBulkNewLostReferringDomainsLiveRequest input)
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
        if (input.DateFrom != null)
            body["date_from"] = input.DateFrom.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_new_lost_referring_domains/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkNewLostReferringDomainsLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkNewLostReferringDomainsLive", false);
    }

    [Action("Search backlink bulk pages summary", Description = "This endpoint will provide you with a comprehensive overview of backlinks and related data for a bulk of up to 1000 pages, domains, or subdomains. If you indicate a single page as a target, you will get comprehensive sum")]
    public async Task<ReportResponse<BacklinksBulkPagesSummaryLiveResultInfo>> BacklinksBulkPagesSummaryLive([ActionParameter] BacklinksBulkPagesSummaryLiveRequest input)
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
        if (input.IncludeSubdomains != null)
            body["include_subdomains"] = input.IncludeSubdomains;
        if (input.RankScale != null)
            body["rank_scale"] = input.RankScale;
        if (input.Tag != null)
            body["tag"] = input.Tag;
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/backlinks/bulk_pages_summary/live", Method.Post).AddStringBody(JsonConvert.SerializeObject(new[] { body }), DataFormat.Json);
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<BacklinksBulkPagesSummaryLiveResultInfo>(fileManagementClient, [response], "BacklinksBulkPagesSummaryLive", false);
    }
}
