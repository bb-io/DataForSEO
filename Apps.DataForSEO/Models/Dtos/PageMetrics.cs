using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PageMetrics
{
    [Display("Links external")]
    [JsonProperty("links_external")]
    public long? LinksExternal { get; set; }

    [Display("Links internal")]
    [JsonProperty("links_internal")]
    public long? LinksInternal { get; set; }

    [Display("Duplicate title")]
    [JsonProperty("duplicate_title")]
    public long? DuplicateTitle { get; set; }

    [Display("Duplicate description")]
    [JsonProperty("duplicate_description")]
    public long? DuplicateDescription { get; set; }

    [Display("Duplicate content")]
    [JsonProperty("duplicate_content")]
    public long? DuplicateContent { get; set; }

    [Display("Broken links")]
    [JsonProperty("broken_links")]
    public long? BrokenLinks { get; set; }

    [Display("Broken resources")]
    [JsonProperty("broken_resources")]
    public long? BrokenResources { get; set; }

    [Display("Links relation conflict")]
    [JsonProperty("links_relation_conflict")]
    public long? LinksRelationConflict { get; set; }

    [Display("Redirect loop")]
    [JsonProperty("redirect_loop")]
    public long? RedirectLoop { get; set; }

    [Display("Onpage score")]
    [JsonProperty("onpage_score")]
    public double? OnpageScore { get; set; }

    [Display("Non indexable")]
    [JsonProperty("non_indexable")]
    public long? NonIndexable { get; set; }

    [Display("Checks")]
    [JsonProperty("checks")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Checks { get; set; }
}
