using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpYahooOrganicLiveAdvancedRequest
{
    [Display("URL", Description = "direct URL of the search queryoptional fieldyou can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn\u2019t recommend using this method.example:https://sea")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Keyword", Description = "keywordrequired fieldyou can specify up to 700 characters in the keyword fieldall %## will be decoded (plus character '+' will be decoded to a space character)if you need to use the \"%\" character for your keyword, please specify it as \"%25\";if you need to use the \u201c+\u201d character for your keyword, please specify it as \u201c%2B\u201dlearn more about r")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYahooOrganicLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Location coordinate", Description = "GPS coordinates of a locationrequired field if you don't specify location_name_or location_codeif you use this field, you don't need to specify location_name or location_codelocation_coordinate parameter should be specified in the \"latitude,longitude,radius\" formatthe maximum number of decimal digits for \"latitude\" and \"longitude\": 7the m")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYahooOrganicLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Device", Description = "device typeoptional fieldreturn results for a specific device typecan take the values:desktop, mobiledefault value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("OS", Description = "device operating systemoptional fieldif you specify desktop in the device field, choose from the following values: windows, macosdefault value: windowsif you specify mobile in the device field, choose from the following values: android, iosdefault value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYahooOrganicLiveAdvancedOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Se domain", Description = "search engine domainoptional fieldwe choose the relevant search engine domain automatically according to the location and language you specifyhowever, you can set a custom search engine domain in this fieldexample:au.search.yahoo.com, uk.search.yahoo.com, ca.search.yahoo.com, etc.")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }

    [Display("Depth", Description = "parsing depthoptional fieldnumber of results in SERPdefault value: 6max value: 200Your account will be billed per each SERP; Each Yahoo SERP can contain fewer than 10 results, so setting depth above the default value may result in additional charges ;The cost can be calculated on the Pricing page.")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Max crawl pages", Description = "page crawl limitoptional fieldnumber of search results pages to crawldefault value: 1max value: 100Note: the max_crawl_pages and depth parameters complement each other;learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Target", Description = "target domain, subdomain, or webpage to get results foroptional fielda domain or a subdomain should be specified without https:// and www.note that the results of target-specific tasks will only include SERP elements that contain a url string;you can also use a wildcard (\u2018\u2019) character to specify the search pattern in SERP and narrow down ")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Search param", Description = "additional parameters of the search queryoptional fieldget the list of available parameters and additional details here")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Tag", Description = "user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
