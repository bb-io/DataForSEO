using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleOrganicLiveHtmlRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character '+' will be decoded to a space character) if you need to use the \"%\" character for your keyword , please specify it as \"%25\"; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; if this f")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicLiveHtmlLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicLiveHtmlLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 10 max value: 200 Your account will be billed per each SERP containing up to 10 results; Setting depth above 10 may result in additional charges if the search engine returns more than 10 results ; The cost can be calculated on the Pricing page.")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("Load async ai overview", Description = "load asynchronous ai overview optional field set to true to obtain ai_overview items is SERPs even if they are loaded asynchronously; if set to false , you will only obtain ai_overview items from cache; default value: false Note your account will be billed $0.002 extra for each request; if the element is absent or contains \"asynchronous_a")]
    [JsonProperty("load_async_ai_overview")]
    public bool? LoadAsyncAiOverview { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicLiveHtmlOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl max value: 100 Note: you will be charged for each page crawled (10 organic results per page); learn more about pricing on our Pricing page; Note#2: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here Note: the following search engine parameters are not supported and will be automatically unset if specified: lr , cr , as_qdr , as_sitesearch , as_occt , as_filetype .")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Expand ai overview", Description = "expand ai overview optional field set to true to expand the ai_overview item; default value: false")]
    [JsonProperty("expand_ai_overview")]
    public bool? ExpandAiOverview { get; set; }

    [Display("URL", Description = "direct URL of the search query optional field you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn\u2019t recommend using this method. example: https:/")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude,radius\" format the maximum number of decimal digits for \"latitude\" and \"longitude\" : 7")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Se domain", Description = "search engine domain optional field we choose the relevant search engine domain automatically according to the location and language you specify however, you can set a custom search engine domain in this field example: google.co.uk , google.com.au , google.de , etc.")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }
}
