using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixOnPagePriceData
{
    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Lighthouse")]
    [JsonProperty("lighthouse")]
    public AppendixLlmResponsesAiOptimizationPriceData? Lighthouse { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Content parsing")]
    [JsonProperty("content_parsing")]
    public AppendixTaskKeywordsDataPriceDataInfo? ContentParsing { get; set; }

    [Display("Content parsing live")]
    [JsonProperty("content_parsing_live")]
    public AppendixTaskKeywordsDataPriceDataInfo? ContentParsingLive { get; set; }

    [Display("Duplicate content")]
    [JsonProperty("duplicate_content")]
    public AppendixTaskKeywordsDataPriceDataInfo? DuplicateContent { get; set; }

    [Display("Duplicate tags")]
    [JsonProperty("duplicate_tags")]
    public AppendixTaskKeywordsDataPriceDataInfo? DuplicateTags { get; set; }

    [Display("Instant pages")]
    [JsonProperty("instant_pages")]
    public AppendixTaskKeywordsDataPriceDataInfo? InstantPages { get; set; }

    [Display("Keyword density")]
    [JsonProperty("keyword_density")]
    public AppendixTaskKeywordsDataPriceDataInfo? KeywordDensity { get; set; }

    [Display("Links")]
    [JsonProperty("links")]
    public AppendixTaskKeywordsDataPriceDataInfo? Links { get; set; }

    [Display("Non indexable")]
    [JsonProperty("non_indexable")]
    public AppendixTaskKeywordsDataPriceDataInfo? NonIndexable { get; set; }

    [Display("Pages")]
    [JsonProperty("pages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Pages { get; set; }

    [Display("Pages by resource")]
    [JsonProperty("pages_by_resource")]
    public AppendixTaskKeywordsDataPriceDataInfo? PagesByResource { get; set; }

    [Display("Page screenshot")]
    [JsonProperty("page_screenshot")]
    public AppendixTaskKeywordsDataPriceDataInfo? PageScreenshot { get; set; }

    [Display("Raw HTML")]
    [JsonProperty("raw_html")]
    public AppendixTaskKeywordsDataPriceDataInfo? RawHtml { get; set; }

    [Display("Redirect chains")]
    [JsonProperty("redirect_chains")]
    public AppendixTaskKeywordsDataPriceDataInfo? RedirectChains { get; set; }

    [Display("Resources")]
    [JsonProperty("resources")]
    public AppendixTaskKeywordsDataPriceDataInfo? Resources { get; set; }

    [Display("Summary")]
    [JsonProperty("summary")]
    public AppendixTaskKeywordsDataPriceDataInfo? Summary { get; set; }

    [Display("Task post")]
    [JsonProperty("task_post")]
    public AppendixTaskKeywordsDataPriceDataInfo? TaskPost { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }

    [Display("Uncrawlable resources")]
    [JsonProperty("uncrawlable_resources")]
    public AppendixTaskKeywordsDataPriceDataInfo? UncrawlableResources { get; set; }

    [Display("Waterfall")]
    [JsonProperty("waterfall")]
    public AppendixTaskKeywordsDataPriceDataInfo? Waterfall { get; set; }
}
