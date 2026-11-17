using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleSearchByImageTaskPostRequest
{
    [Display("Image URL", Description = "URL of the image required field the results will be based on the image you specified in this field example: https://upload.wikimedia.org/wikipedia/commons/e/ed/Elon_Musk_Royal_Society.jpg")]
    [JsonProperty("image_url")]
    public string ImageUrl { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleSearchByImageTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleSearchByImageTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Postback data", Description = "postback_url datatype required field if you specify postback_url corresponds to the datatype that will be sent to your server possible values: advanced , html")]
    [JsonProperty("postback_data")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PostbackDataOptions6))]
    public string PostbackData { get; set; } = string.Empty;

    [Display("Priority", Description = "task priority optional field can take the following values: 1 \u2013 normal execution priority (set by default) 2 \u2013 high execution priority You will be additionally charged for the tasks with high execution priority. The cost can be calculated on the Pricing page")]
    [JsonProperty("priority")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PriorityOptions4))]
    public string? Priority { get; set; }

    [Display("Resolve goto URLS", Description = "resolve goto redirect URLs optional field set to true to resolve goto redirect URLs in SERPs for tasks with high execution priority default value for tasks with priority: 1 is true default value for tasks with priority: 2 is false Note: this parameter adds up to 40 seconds to the turnaround time of high-priority tasks, with a maximum turn")]
    [JsonProperty("resolve_goto_urls")]
    public bool? ResolveGotoUrls { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl max value: 100 Note: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here")]
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

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude,radius\" format the maximum number of decimal digits for \"latitude\" and \"longitude\" : 7")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Se domain", Description = "search engine domain optional field we choose the relevant search engine domain automatically according to the location and language you specify however, you can set a custom search engine domain in this field example: google.co.uk , google.com.au , google.de , etc.")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }
}
