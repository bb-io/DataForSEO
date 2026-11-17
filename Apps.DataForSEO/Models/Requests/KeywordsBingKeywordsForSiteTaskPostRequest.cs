using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class KeywordsBingKeywordsForSiteTaskPostRequest
{
    [Display("Target", Description = "domain or URL required field the URL of the webpage or the domain to scan for possible keywords")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsBingKeywordsForSiteTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude\" format the data will be provided for the country the specified coordinates belong to ")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsBingKeywordsForSiteTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Keywords negative", Description = "keywords negative array optional field These keywords will be ignored in the results array; You can specify a maximum of 200 terms that you want to exclude from the results; the specified keywords will be converted to lowercase format")]
    [JsonProperty("keywords_negative")]
    public List<string>? KeywordsNegative { get; set; }

    [Display("Device", Description = "device type optional field specify this field if you want to get the data for a particular device type possible values: all , mobile , desktop , tablet default value: all")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("Sort by", Description = "results sorting parameters optional field Use these parameters to sort the results by search_volume , cpc , competition or relevance in the descending order default value: relevance")]
    [JsonProperty("sort_by")]
    public string? SortBy { get; set; }

    [Display("Date from", Description = "starting date of the time range optional field minimal value: 24 months from today's date; if you don't specify this field, data will be provided for the last 12 months; if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior; if Status endpoint returns true in the actual_data fie")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, data will be provided for the last 12 months; minimum value: two years back from today\u2019s date; maximum value: one month from today's date; date format: \"yyyy-mm-dd\" example: \"2020-03-15\" Note: we do not recommend using a custom time range for the past year's dat")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Search partners", Description = "Bing search partners type optional field if you specify true , the results will be delivered for owned, operated, and syndicated networks across Bing, Yahoo, AOL and partner sites that host Bing, AOL, and Yahoo search. default value: false - results are returned for Bing, AOL, and Yahoo search networks")]
    [JsonProperty("search_partners")]
    public bool? SearchPartners { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
