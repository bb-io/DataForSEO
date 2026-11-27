using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksSummaryLiveRequest
{
    [Display("Target", Description = "domain, subdomain or webpage to get data for required field a domain or a subdomain should be specified without https:// and www. a page should be specified with absolute URL (including http:// or https:// )")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Include subdomains", Description = "indicates if the subdomains of the target will be included in the search optional field if set to false , the subdomains will be ignored default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Include indirect links", Description = "indicates if indirect links to the target will be included in the results optional field if set to true , the results will include data on indirect links pointing to a page that either redirects to the target, or points to a canonical page if set to false , indirect links will be ignored default value: true")]
    [JsonProperty("include_indirect_links")]
    public bool? IncludeIndirectLinks { get; set; }

    [Display("Exclude internal backlinks", Description = "indicates if internal backlinks from subdomains to the target will be excluded from the results optional field if set to true , the results will not include data on internal backlinks from subdomains of the same domain as target if set to false , internal links will be included in the results default value: true")]
    [JsonProperty("exclude_internal_backlinks")]
    public bool? ExcludeInternalBacklinks { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: referring_links_tld referring_links_types referring_links_attributes referring_links_platform_types referring_links_semantic_locations default value: 10 maximum value: 1000")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Backlinks status type", Description = "set what backlinks to return and count optional field you can use this field to choose what backlinks will be returned and used for aggregated metrics for your target ; possible values: all - all backlinks will be returned and counted; live - backlinks found during the last check will be returned and counted; lost - lost backlinks will be")]
    [JsonProperty("backlinks_status_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BacklinksStatusTypeOptions13))]
    public string? BacklinksStatusType { get; set; }

    [Display("Backlinks filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. filter the backlinks of your target optional field you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your targe")]
    [JsonProperty("backlinks_filters")]
    public string? BacklinksFiltersJson { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank , domain_from_rank , and page_from_rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
