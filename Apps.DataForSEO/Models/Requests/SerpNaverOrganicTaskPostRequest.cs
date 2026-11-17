using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpNaverOrganicTaskPostRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d learn more")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("URL", Description = "direct URL of the search query optional field you can specify a direct URL and we will sort it out to the necessary fields in most cases, we wouldn\u2019t recommend using this method; example: https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=iphone")]
    [JsonProperty("url")]
    public string? Url { get; set; }

    [Display("Priority", Description = "task priority optional field can take the following values: 1 \u2013 normal execution priority (set by default) 2 \u2013 high execution priorityYou will be additionally charged for the tasks with high execution priority. The cost can be calculated on the Pricing page.")]
    [JsonProperty("priority")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PriorityOptions4))]
    public string? Priority { get; set; }

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 20 max value: 700 Your account will be billed per each SERP containing up to 20 results; Setting depth above 20 may result in additional charges if the search engine returns more than 20 results ; The cost can be calculated on the Pricing page.")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl default value: 1 max value: 100 Note: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpNaverOrganicTaskPostOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Se domain", Description = "search engine domain optional field we choose the relevant search engine domain automatically however, you can set a custom search engine domain in this field example: search.naver.com")]
    [JsonProperty("se_domain")]
    public string? SeDomain { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Postback data", Description = "postback_url datatype required field if you specify postback_url corresponds to the function you used for setting a task possible values: regular , advanced , html")]
    [JsonProperty("postback_data")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PostbackDataOptions3))]
    public string PostbackData { get; set; } = string.Empty;

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }
}
