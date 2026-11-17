using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PageMetaInfo
{
    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Charset")]
    [JsonProperty("charset")]
    public long? Charset { get; set; }

    [Display("Follow")]
    [JsonProperty("follow")]
    public bool? Follow { get; set; }

    [Display("Generator")]
    [JsonProperty("generator")]
    public string? Generator { get; set; }

    [Display("Htags")]
    [JsonProperty("htags")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Htags { get; set; }

    [Display("Description")]
    [JsonProperty("description")]
    public string? Description { get; set; }

    [Display("Favicon")]
    [JsonProperty("favicon")]
    public string? Favicon { get; set; }

    [Display("Meta keywords")]
    [JsonProperty("meta_keywords")]
    public string? MetaKeywords { get; set; }

    [Display("Canonical")]
    [JsonProperty("canonical")]
    public string? Canonical { get; set; }

    [Display("Internal links count")]
    [JsonProperty("internal_links_count")]
    public long? InternalLinksCount { get; set; }

    [Display("External links count")]
    [JsonProperty("external_links_count")]
    public long? ExternalLinksCount { get; set; }

    [Display("Inbound links count")]
    [JsonProperty("inbound_links_count")]
    public long? InboundLinksCount { get; set; }

    [Display("Images count")]
    [JsonProperty("images_count")]
    public long? ImagesCount { get; set; }

    [Display("Images size")]
    [JsonProperty("images_size")]
    public long? ImagesSize { get; set; }

    [Display("Scripts count")]
    [JsonProperty("scripts_count")]
    public long? ScriptsCount { get; set; }

    [Display("Scripts size")]
    [JsonProperty("scripts_size")]
    public long? ScriptsSize { get; set; }

    [Display("Stylesheets count")]
    [JsonProperty("stylesheets_count")]
    public long? StylesheetsCount { get; set; }

    [Display("Stylesheets size")]
    [JsonProperty("stylesheets_size")]
    public long? StylesheetsSize { get; set; }

    [Display("Title length")]
    [JsonProperty("title_length")]
    public long? TitleLength { get; set; }

    [Display("Description length")]
    [JsonProperty("description_length")]
    public long? DescriptionLength { get; set; }

    [Display("Render blocking scripts count")]
    [JsonProperty("render_blocking_scripts_count")]
    public long? RenderBlockingScriptsCount { get; set; }

    [Display("Render blocking stylesheets count")]
    [JsonProperty("render_blocking_stylesheets_count")]
    public long? RenderBlockingStylesheetsCount { get; set; }

    [Display("Cumulative layout shift")]
    [JsonProperty("cumulative_layout_shift")]
    public double? CumulativeLayoutShift { get; set; }

    [Display("Meta title")]
    [JsonProperty("meta_title")]
    public string? MetaTitle { get; set; }

    [Display("Content")]
    [JsonProperty("content")]
    public HtmlContentInfo? Content { get; set; }

    [Display("Deprecated tags")]
    [JsonProperty("deprecated_tags", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> DeprecatedTags { get; set; } = [];

    [Display("Duplicate meta tags")]
    [JsonProperty("duplicate_meta_tags", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> DuplicateMetaTags { get; set; } = [];

    [Display("Spell")]
    [JsonProperty("spell")]
    public HunspellInfo? Spell { get; set; }

    [Display("Social media tags")]
    [JsonProperty("social_media_tags")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? SocialMediaTags { get; set; }

    [Display("Broken HTML")]
    [JsonProperty("broken_html")]
    public OnPageResourceIssueInfo? BrokenHtml { get; set; }
}
