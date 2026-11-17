using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksBacklinksLiveRequest
{
    [Display("Target", Description = "domain, subdomain or webpage to get backlinks for required field a domain or a subdomain should be specified without https:// and www. a page should be specified with absolute URL (including http:// or https:// )")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Mode", Description = "results grouping type optional field possible grouping types: as_is - returns all backlinks one_per_domain - returns one backlink per domain one_per_anchor - returns one backlink per anchor default value: as_is")]
    [JsonProperty("mode")]
    public string? Mode { get; set; }

    [Display("Custom mode JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. detailed results grouping type optional field use this object to get a specific number of backlinks per field if you use custom_mode , then mode will be ignored example: \"custom_mo")]
    [JsonProperty("custom_mode")]
    public string? CustomModeJson { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"rank,desc\"] note that you can set no more ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Backlinks status type", Description = "set what backlinks to return and count optional field you can use this field to choose what backlinks will be returned and used for aggregated metrics for your target ; possible values: all - all backlinks will be returned and counted; live - backlinks found during the last check will be returned and counted; lost - lost backlinks will be")]
    [JsonProperty("backlinks_status_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BacklinksStatusTypeOptions13))]
    public string? BacklinksStatusType { get; set; }

    [Display("Include subdomains", Description = "indicates if the subdomains of the target will be included in the search optional field if set to false , the subdomains will be ignored default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Exclude internal backlinks", Description = "indicates if internal backlinks from subdomains to the target will be excluded from the results optional field if set to true , the results will not include data on internal backlinks from subdomains of the same domain as target if set to false , internal links will be included in the results default value: true")]
    [JsonProperty("exclude_internal_backlinks")]
    public bool? ExcludeInternalBacklinks { get; set; }

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
