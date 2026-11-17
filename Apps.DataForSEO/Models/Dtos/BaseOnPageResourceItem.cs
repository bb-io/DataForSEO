using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseOnPageResourceItem
{
    [Display("Resource type")]
    [JsonProperty("resource_type")]
    public string? ResourceType { get; set; }

    [Display("Status code")]
    [JsonProperty("status_code")]
    public long? StatusCode { get; set; }

    [Display("Location")]
    [JsonProperty("location")]
    public string? Location { get; set; }

    [Display("URL")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Resource errors")]
    [JsonProperty("resource_errors")]
    public OnPageResourceIssueInfo? ResourceErrors { get; set; }

    [Display("Size")]
    [JsonProperty("size")]
    public long? Size { get; set; }

    [Display("Encoded size")]
    [JsonProperty("encoded_size")]
    public long? EncodedSize { get; set; }

    [Display("Total transfer size")]
    [JsonProperty("total_transfer_size")]
    public long? TotalTransferSize { get; set; }

    [Display("Fetch time")]
    [JsonProperty("fetch_time")]
    public string? FetchTime { get; set; }

    [Display("Cache control")]
    [JsonProperty("cache_control")]
    public CacheControl? CacheControl { get; set; }

    [Display("Checks")]
    [JsonProperty("checks")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Checks { get; set; }

    [Display("Content encoding")]
    [JsonProperty("content_encoding")]
    public string? ContentEncoding { get; set; }

    [Display("Media type")]
    [JsonProperty("media_type")]
    public string? MediaType { get; set; }

    [Display("Server")]
    [JsonProperty("server")]
    public string? Server { get; set; }

    [Display("Last modified")]
    [JsonProperty("last_modified")]
    public LastModified? LastModified { get; set; }

    [Display("Meta")]
    [JsonProperty("meta")]
    public PageMetaInfo? Meta { get; set; }

    [Display("Page timing")]
    [JsonProperty("page_timing")]
    public PageTiming? PageTiming { get; set; }

    [Display("Onpage score")]
    [JsonProperty("onpage_score")]
    public double? OnpageScore { get; set; }

    [Display("Total dom size")]
    [JsonProperty("total_dom_size")]
    public long? TotalDomSize { get; set; }

    [Display("Custom js response")]
    [JsonProperty("custom_js_response")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? CustomJsResponse { get; set; }

    [Display("Custom js client exception")]
    [JsonProperty("custom_js_client_exception")]
    public string? CustomJsClientException { get; set; }

    [Display("Broken resources")]
    [JsonProperty("broken_resources")]
    public bool? BrokenResources { get; set; }

    [Display("Broken links")]
    [JsonProperty("broken_links")]
    public bool? BrokenLinks { get; set; }

    [Display("Duplicate title")]
    [JsonProperty("duplicate_title")]
    public bool? DuplicateTitle { get; set; }

    [Display("Duplicate description")]
    [JsonProperty("duplicate_description")]
    public bool? DuplicateDescription { get; set; }

    [Display("Duplicate content")]
    [JsonProperty("duplicate_content")]
    public bool? DuplicateContent { get; set; }

    [Display("Click depth")]
    [JsonProperty("click_depth")]
    public long? ClickDepth { get; set; }

    [Display("Is resource")]
    [JsonProperty("is_resource")]
    public bool? IsResource { get; set; }

    [Display("URL length")]
    [JsonProperty("url_length")]
    public long? UrlLength { get; set; }

    [Display("Relative URL length")]
    [JsonProperty("relative_url_length")]
    public long? RelativeUrlLength { get; set; }

    [Display("Fetch timing")]
    [JsonProperty("fetch_timing")]
    public FetchTiming? FetchTiming { get; set; }

    [Display("Accept type")]
    [JsonProperty("accept_type")]
    public string? AcceptType { get; set; }
}
