using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksDomainIntersectionLiveRequest
{
    [Display("Targets JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. domains, subdomains or webpages to get links for required field you can set up to 20 domains, subdomains or webpages a domain or a subdomain should be specified without https:// an")]
    [JsonProperty("targets")]
    public string TargetsJson { get; set; } = string.Empty;

    [Display("Exclude targets", Description = "domains, subdomains or webpages you want to exclude optional field you can specify up to 10 domains, subdomains or webpages if you use this array, results will contain the referring domains that link to targets but don't link to exclude_targets example: `\"exclude_targets\": [ \"bbc.com\", \"https://www.apple.com/iphone/*\", \"https://dataforseo")]
    [JsonProperty("exclude_targets")]
    public List<string>? ExcludeTargets { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"backlinks,desc\"] note that you can set no ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: referring_links_tld referring_links_types referring_links_attributes referring_links_platform_types referring_links_semantic_locations default value: 10 maximum value: 1000")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Backlinks status type", Description = "set what backlinks to return and count optional field you can use this field to choose what backlinks will be returned and used for aggregated metrics for your targets ; possible values: all - all backlinks will be returned and counted; live - backlinks found during the last check will be returned and counted; lost - lost backlinks will b")]
    [JsonProperty("backlinks_status_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BacklinksStatusTypeOptions13))]
    public string? BacklinksStatusType { get; set; }

    [Display("Backlinks filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. filter the backlinks of your target optional field you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your targe")]
    [JsonProperty("backlinks_filters")]
    public string? BacklinksFiltersJson { get; set; }

    [Display("Include subdomains", Description = "indicates if the subdomains of the target will be included in the search optional field if set to false , the subdomains will be ignored default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Include indirect links", Description = "indicates if indirect links to the targets will be included in the results optional field if set to true , the results will include data on indirect links pointing to a page that either redirects to a target, or points to a canonical page if set to false , indirect links will be ignored default value: true")]
    [JsonProperty("include_indirect_links")]
    public bool? IncludeIndirectLinks { get; set; }

    [Display("Exclude internal backlinks", Description = "indicates whether the backlinks from subdomains of the target are excluded optional field if set to false , the backlinks from subdomains of the target will be omitted and you won't receive the same domain in the response; default value: true")]
    [JsonProperty("exclude_internal_backlinks")]
    public bool? ExcludeInternalBacklinks { get; set; }

    [Display("Intersection mode", Description = "indicates whether to intersect backlinks optional field use this field to intersect or merge results for the specified domains possible values: all , partial all - results are based on all backlinks; partial - results are based on the intersecting backlinks only; default value: all")]
    [JsonProperty("intersection_mode")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.IntersectionModeOptions16))]
    public string? IntersectionMode { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank , domain_from_rank , and page_from_rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
