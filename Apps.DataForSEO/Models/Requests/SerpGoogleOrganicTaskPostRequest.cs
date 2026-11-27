using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleOrganicTaskPostRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; if this f")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 10 max value: 700 Your account will be billed per each SERP containing up to 10 results; Setting depth above 10 may result in additional charges if the search engine returns more than 10 results ; The cost can be calculated on the Pricing page.")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("Load async ai overview", Description = "load asynchronous ai overview optional field set to true to obtain ai_overview items is SERPs even if they are loaded asynchronously; if set to false , you will only obtain ai_overview items from cache; default value: false Note: you will be charged extra $0.0006 for using this parameter; if the element is absent or contains \"asynchronous")]
    [JsonProperty("load_async_ai_overview")]
    public bool? LoadAsyncAiOverview { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request example: htt")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Postback data", Description = "postback_url datatype required field if you specify postback_url corresponds to the datatype that will be sent to your server possible values: regular , advanced , html")]
    [JsonProperty("postback_data")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PostbackDataOptions3))]
    public string? PostbackData { get; set; }

    [Display("Priority", Description = "task priority optional field can take the following values: 1 \u2013 normal execution priority (set by default); 2 \u2013 high execution priority You will be additionally charged for the tasks with high execution priority. The cost can be calculated on the Pricing page.")]
    [JsonProperty("priority")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PriorityOptions4))]
    public string? Priority { get; set; }

    [Display("Resolve goto URLS", Description = "resolve goto redirect URLs optional field set to true to resolve goto redirect URLs in SERPs for tasks with high execution priority default value for tasks with priority: 1 is true default value for tasks with priority: 2 is false Note: this parameter adds up to 40 seconds to the turnaround time of high-priority tasks, with a maximum turn")]
    [JsonProperty("resolve_goto_urls")]
    public bool? ResolveGotoUrls { get; set; }

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude,radius\" format the maximum number of decimal digits for \"latitude\" and \"longitude\" : 7")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleOrganicTaskPostOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl max value: 100 Note: you will be charged for each page crawled (10 organic results per page); learn more about pricing on our Pricing page; Note#2: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here Note: the following search engine parameters are not supported and will be automatically unset if specified: lr , cr , as_qdr , as_sitesearch , as_occt , as_filetype .")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Remove from URL", Description = "remove specific parameters from URLs optional field using this field, you can specify up to 10 parameters to remove from URLs in the result example: \"remove_from_url\": [\"srsltid\"]")]
    [JsonProperty("remove_from_url")]
    public List<string>? RemoveFromUrl { get; set; }

    [Display("Expand ai overview", Description = "expand ai overview optional field set to true to expand the ai_overview item; default value: false ; Note: this parameter applies only to HTML task results")]
    [JsonProperty("expand_ai_overview")]
    public bool? ExpandAiOverview { get; set; }

    [Display("People also ask click depth", Description = "clicks on the corresponding element optional field specify the click depth on the people_also_ask element to get additional people_also_ask_element items; Note your account will be billed $0.00015 extra for each click regardless of task priority; if the element is absent or we perform fewer clicks than you specified, all extra charges wil")]
    [JsonProperty("people_also_ask_click_depth")]
    public long? PeopleAlsoAskClickDepth { get; set; }

    [Display("Group organic results", Description = "display related results optional field if set to true , the related_result element in the response will be provided as a snippet of its parent organic result; if set to false , the related_result element will be provided as a separate organic result; default value: true")]
    [JsonProperty("group_organic_results")]
    public bool? GroupOrganicResults { get; set; }

    [Display("Calculate rectangles", Description = "calcualte pixel rankings for SERP elements in advanced results optional field pixel ranking refers to the distance between the result snippet and top left corner of the screen; Visit Help Center to learn more>> by default, the parameter is set to false Note: you will be charged extra $0.0006 for using this parameter")]
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

    [Display("Se domain", Description = "search engine domain optional field we choose the relevant search engine domain automatically according to the location and language you specify however, you can set a custom search engine domain in this field example: google.co.uk , google.com.au , google.de , etc.")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }
}
