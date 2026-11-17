using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleAutocompleteTaskPostRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; learn mor")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAutocompleteTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAutocompleteTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Cursor pointer", Description = "search bar cursor pointer optional field the horizontal numerical position of the cursor pointer within the keyword in the search bar; by modifying the position of the cursor pointer, you will obtain different autocomplete suggestions for the same seed keyword; minimal value: 0 default value: the number of the last character of the specif")]
    [JsonProperty("cursor_pointer")]
    public long? CursorPointer { get; set; }

    [Display("Priority", Description = "task priority optional field can take the following values: 1 \u2013 normal execution priority (set by default); 2 \u2013 high execution priority You will be additionally charged for the tasks with high execution priority; The cost can be calculated on the Pricing page")]
    [JsonProperty("priority")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PriorityOptions4))]
    public string? Priority { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request example: htt")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Postback data", Description = "postback_url datatype required field if you specify postback_url corresponds to the datatype that will be sent to your server possible values: advanced")]
    [JsonProperty("postback_data")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PostbackDataOptions7))]
    public string PostbackData { get; set; } = string.Empty;

    [Display("Client", Description = "search client for autocomplete optional field autocomplete results may differ depending on the search client; possible values: chrome \u2014 used when google search is opened in google chrome; chrome-omni \u2014 used in the address bar in chrome; gws-wiz \u2014 used in google search home page; gws-wiz-serp \u2014 used in google search engine results page; sa")]
    [JsonProperty("client")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ClientOptions8))]
    public string? Client { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
