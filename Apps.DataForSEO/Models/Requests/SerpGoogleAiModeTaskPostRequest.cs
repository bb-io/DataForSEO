using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleAiModeTaskPostRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d learn more")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAiModeTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAiModeTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Priority", Description = "task priority optional field can take the following values: 1 \u2013 normal execution priority (set by default) 2 \u2013 high execution priority You will be additionally charged for the tasks with high execution priority. The cost can be calculated on the Pricing page.")]
    [JsonProperty("priority")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PriorityOptions4))]
    public string? Priority { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Postback data", Description = "postback_url datatype required field if you specify postback_url corresponds to the function you used for setting a task possible values: advanced , html")]
    [JsonProperty("postback_data")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PostbackDataOptions6))]
    public string PostbackData { get; set; } = string.Empty;

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAiModeTaskPostOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Calculate rectangles", Description = "calculate pixel rankings for SERP elements in advanced results optional field pixel ranking refers to the distance between the result snippet and top left corner of the screen; Visit Help Center to learn more>> by default, the parameter is set to false Note: if set to true , the charge per task will be multiplied by 2")]
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

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude,zoom\" format if \"zoom\" is not specified, 9z will be applied as a default value the max")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;
}
