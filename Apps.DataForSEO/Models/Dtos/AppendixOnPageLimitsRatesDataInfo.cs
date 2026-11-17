using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixOnPageLimitsRatesDataInfo
{
    [Display("Task post")]
    [JsonProperty("task_post")]
    public double? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public double? Summary { get; set; }

    [Display("Resources")]
    [JsonProperty("resources")]
    public double? Resources { get; set; }

    [Display("Pages")]
    [JsonProperty("pages")]
    public double? Pages { get; set; }

    [Display("Non indexable")]
    [JsonProperty("non_indexable")]
    public double? NonIndexable { get; set; }

    [Display("Duplicate tags")]
    [JsonProperty("duplicate_tags")]
    public double? DuplicateTags { get; set; }

    [Display("Links")]
    [JsonProperty("links")]
    public double? Links { get; set; }

    [Display("Waterfall")]
    [JsonProperty("waterfall")]
    public double? Waterfall { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Pages by resource")]
    [JsonProperty("pages_by_resource")]
    public double? PagesByResource { get; set; }

    [Display("Duplicate content")]
    [JsonProperty("duplicate_content")]
    public double? DuplicateContent { get; set; }

    [Display("Raw HTML")]
    [JsonProperty("raw_html")]
    public double? RawHtml { get; set; }

    [Display("Instant pages")]
    [JsonProperty("instant_pages")]
    public double? InstantPages { get; set; }

    [Display("Redirect chains")]
    [JsonProperty("redirect_chains")]
    public double? RedirectChains { get; set; }

    [Display("Lighthouse")]
    [JsonProperty("lighthouse")]
    public AppendixInfo? Lighthouse { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("Keyword density")]
    [JsonProperty("keyword_density")]
    public double? KeywordDensity { get; set; }

    [Display("Page screenshot")]
    [JsonProperty("page_screenshot")]
    public double? PageScreenshot { get; set; }

    [Display("Content parsing")]
    [JsonProperty("content_parsing")]
    public double? ContentParsing { get; set; }

    [Display("Content parsing live")]
    [JsonProperty("content_parsing_live")]
    public double? ContentParsingLive { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Uncrawlable resources")]
    [JsonProperty("uncrawlable_resources")]
    public double? UncrawlableResources { get; set; }
}
