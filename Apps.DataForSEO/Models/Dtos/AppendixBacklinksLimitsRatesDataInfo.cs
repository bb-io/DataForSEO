using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBacklinksLimitsRatesDataInfo
{
    [Display("Summary")]
    [JsonProperty("summary")]
    public AppendixInfo? Summary { get; set; }

    [Display("History")]
    [JsonProperty("history")]
    public AppendixInfo? History { get; set; }

    [Display("Content duplicates")]
    [JsonProperty("content_duplicates")]
    public AppendixInfo? ContentDuplicates { get; set; }

    [Display("Domain intersection")]
    [JsonProperty("domain_intersection")]
    public AppendixInfo? DomainIntersection { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public AppendixInfo? Backlinks { get; set; }

    [Display("Domain pages")]
    [JsonProperty("domain_pages")]
    public AppendixInfo? DomainPages { get; set; }

    [Display("Domain backlinks")]
    [JsonProperty("domain_backlinks")]
    public AppendixInfo? DomainBacklinks { get; set; }

    [Display("Anchors")]
    [JsonProperty("anchors")]
    public AppendixInfo? Anchors { get; set; }

    [Display("Referring domains")]
    [JsonProperty("referring_domains")]
    public AppendixInfo? ReferringDomains { get; set; }

    [Display("Links intersection")]
    [JsonProperty("links_intersection")]
    public AppendixInfo? LinksIntersection { get; set; }

    [Display("Page intersection")]
    [JsonProperty("page_intersection")]
    public AppendixInfo? PageIntersection { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("Referring networks")]
    [JsonProperty("referring_networks")]
    public AppendixInfo? ReferringNetworks { get; set; }

    [Display("Bulk ranks")]
    [JsonProperty("bulk_ranks")]
    public AppendixInfo? BulkRanks { get; set; }

    [Display("Bulk backlinks")]
    [JsonProperty("bulk_backlinks")]
    public AppendixInfo? BulkBacklinks { get; set; }

    [Display("Bulk new lost backlinks")]
    [JsonProperty("bulk_new_lost_backlinks")]
    public AppendixInfo? BulkNewLostBacklinks { get; set; }

    [Display("Bulk new lost referring domains")]
    [JsonProperty("bulk_new_lost_referring_domains")]
    public AppendixInfo? BulkNewLostReferringDomains { get; set; }

    [Display("Bulk referring domains")]
    [JsonProperty("bulk_referring_domains")]
    public AppendixInfo? BulkReferringDomains { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Domain pages summary")]
    [JsonProperty("domain_pages_summary")]
    public AppendixInfo? DomainPagesSummary { get; set; }

    [Display("Timeseries summary")]
    [JsonProperty("timeseries_summary")]
    public AppendixInfo? TimeseriesSummary { get; set; }

    [Display("Timeseries new lost summary")]
    [JsonProperty("timeseries_new_lost_summary")]
    public AppendixInfo? TimeseriesNewLostSummary { get; set; }

    [Display("Competitors")]
    [JsonProperty("competitors")]
    public AppendixInfo? Competitors { get; set; }

    [Display("Bulk spam score")]
    [JsonProperty("bulk_spam_score")]
    public AppendixInfo? BulkSpamScore { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Bulk pages summary")]
    [JsonProperty("bulk_pages_summary")]
    public AppendixInfo? BulkPagesSummary { get; set; }
}
