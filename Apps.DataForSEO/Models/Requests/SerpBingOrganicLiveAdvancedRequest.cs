using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpBingOrganicLiveAdvancedRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character '+' will be decoded to a space character) if you need to use the \"%\" character for your keyword , please specify it as \"%25\"; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; learn mor")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpBingOrganicLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpBingOrganicLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 10 max value: 200 Your account will be billed per each SERP containing up to 10 results; Setting depth above 10 may result in additional charges if the search engine returns more than 10 results ; The cost can be calculated on the Pricing page.")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpBingOrganicLiveAdvancedOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Target", Description = "target domain, subdomain, or webpage to get results for optional field a domain or a subdomain should be specified without https:// and www. note that the results of target -specific tasks will only include SERP elements that contain a url string; you can also use a wildcard (\u2018*\u2019) character to specify the search pattern in SERP and narrow")]
    [JsonProperty("target")]
    public string? Target { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl default value: 1 max value: 100 Note: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Calculate rectangles", Description = "calculate pixel rankings for SERP elements in advanced results optional field pixel ranking refers to the distance between the result snippet and top left corner of the screen; Visit Help Center to learn more>> by default, the parameter is set to false Note: you will be charged extra $0.002 for using this parameter")]
    [JsonProperty("calculate_rectangles")]
    public bool? CalculateRectangles { get; set; }

    [Display("Browser screen width", Description = "browser screen width optional field you can set a custom browser screen width to calculate pixel rankings for a particular device; can be specified within the following range: 240-9999 ; by default, the parameter is set to: 1920 for desktop ; 360 for mobile on android ; 375 for mobile on iOS ; Note: to use this parameter, set calculate_re")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen height optional field you can set a custom browser screen height to calculate pixel rankings for a particular device; can be specified within the following range: 240-9999 ; by default, the parameter is set to: 1080 for desktop ; 640 for mobile on android ; 812 for mobile on iOS ; Note: to use this parameter, set calculate_")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen resolution ratio", Description = "browser screen resolution ratio optional field you can set a custom browser screen resolution ratio to calculate pixel rankings for a particular device; can be specified within the following range: 0.5-3 ; by default, the parameter is set to: 1 for desktop ; 3 for mobile on android ; 3 for mobile on iOS ; Note: to use this parameter, set ")]
    [JsonProperty("browser_screen_resolution_ratio")]
    public long? BrowserScreenResolutionRatio { get; set; }

    [Display("URL", Description = "direct URL of the search query optional field you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn\u2019t recommend using this method. example: https:/")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude\" format the maximum number of decimal digits for \"latitude\" and \"longitude\" : 7 exampl")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;
}
