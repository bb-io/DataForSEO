using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBacklinksPriceData
{
    [Display("Anchors")]
    [JsonProperty("anchors")]
    public AppendixBingKeywordsDataPriceDataInfo? Anchors { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Backlinks")]
    [JsonProperty("backlinks")]
    public AppendixBingKeywordsDataPriceDataInfo? Backlinks { get; set; }

    [Display("Bulk backlinks")]
    [JsonProperty("bulk_backlinks")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkBacklinks { get; set; }

    [Display("Bulk new lost backlinks")]
    [JsonProperty("bulk_new_lost_backlinks")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkNewLostBacklinks { get; set; }

    [Display("Bulk new lost referring domains")]
    [JsonProperty("bulk_new_lost_referring_domains")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkNewLostReferringDomains { get; set; }

    [Display("Bulk pages summary")]
    [JsonProperty("bulk_pages_summary")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkPagesSummary { get; set; }

    [Display("Bulk ranks")]
    [JsonProperty("bulk_ranks")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkRanks { get; set; }

    [Display("Bulk referring domains")]
    [JsonProperty("bulk_referring_domains")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkReferringDomains { get; set; }

    [Display("Bulk spam score")]
    [JsonProperty("bulk_spam_score")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkSpamScore { get; set; }

    [Display("Competitors")]
    [JsonProperty("competitors")]
    public AppendixBingKeywordsDataPriceDataInfo? Competitors { get; set; }

    [Display("Content duplicates")]
    [JsonProperty("content_duplicates")]
    public AppendixBingKeywordsDataPriceDataInfo? ContentDuplicates { get; set; }

    [Display("Domain backlinks")]
    [JsonProperty("domain_backlinks")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainBacklinks { get; set; }

    [Display("Domain intersection")]
    [JsonProperty("domain_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainIntersection { get; set; }

    [Display("Domain pages")]
    [JsonProperty("domain_pages")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainPages { get; set; }

    [Display("Domain pages summary")]
    [JsonProperty("domain_pages_summary")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainPagesSummary { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("History")]
    [JsonProperty("history")]
    public AppendixBingKeywordsDataPriceDataInfo? History { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Links intersection")]
    [JsonProperty("links_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? LinksIntersection { get; set; }

    [Display("Page intersection")]
    [JsonProperty("page_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? PageIntersection { get; set; }

    [Display("Referring domains")]
    [JsonProperty("referring_domains")]
    public AppendixBingKeywordsDataPriceDataInfo? ReferringDomains { get; set; }

    [Display("Referring networks")]
    [JsonProperty("referring_networks")]
    public AppendixBingKeywordsDataPriceDataInfo? ReferringNetworks { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public AppendixBingKeywordsDataPriceDataInfo? Summary { get; set; }

    [Display("Timeseries new lost summary")]
    [JsonProperty("timeseries_new_lost_summary")]
    public AppendixBingKeywordsDataPriceDataInfo? TimeseriesNewLostSummary { get; set; }

    [Display("Timeseries summary")]
    [JsonProperty("timeseries_summary")]
    public AppendixBingKeywordsDataPriceDataInfo? TimeseriesSummary { get; set; }
}
