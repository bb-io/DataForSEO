using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleNewsLiveAdvancedRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character '+' will be decoded to a space character) if you need to use the \"%\" character for your keyword , please specify it as \"%25\"; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; if this f")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleNewsLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleNewsLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 10 max value: 200 Your account will be billed per each SERP containing up to 10 results; Setting depth above 10 may result in additional charges if the search engine returns more than 10 results; If the specified depth is higher than the number of results in the respons")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Resolve goto URLS", Description = "resolve goto redirect URLs optional field set to true to resolve goto redirect URLs in SERPs default value: false Note: this parameter adds up to 40 seconds to the turnaround time, with a maximum turnaround time of 260 seconds")]
    [JsonProperty("resolve_goto_urls")]
    public bool? ResolveGotoUrls { get; set; }

    [Display("OS", Description = "device operating system optional field note that this API provides results for desktop only choose from the following values: windows , macos default value: windows")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.OsOptions5))]
    public string? Os { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl max value: 100 Note: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field Get the list of available parameters and additional details here.")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Calculate rectangles", Description = "calculate pixel rankings for SERP elements in advanced results optional field pixel ranking refers to the distance between the result snippet and top left corner of the screen; Visit Help Center to learn more>> by default, the parameter is set to false Note: if set to true , the charge per task will be multiplied by 2")]
    [JsonProperty("calculate_rectangles")]
    public bool? CalculateRectangles { get; set; }

    [Display("Browser screen width", Description = "browser screen width optional field you can set a custom browser screen width to calculate pixel rankings for a particular device; by default, the parameter is set to 1920 ; Note: to use this parameter, set calculate_rectangles to true")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen height optional field you can set a custom browser screen height to calculate pixel rankings for a particular device; by default, the parameter is set to 1080 ; Note: to use this parameter, set calculate_rectangles to true")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen resolution ratio", Description = "browser screen resolution ratio optional field you can set a custom browser screen resolution ratio to calculate pixel rankings for a particular device; by default, the parameter is set to 1 ; Note: to use this parameter, set calculate_rectangles to true")]
    [JsonProperty("browser_screen_resolution_ratio")]
    public long? BrowserScreenResolutionRatio { get; set; }

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
