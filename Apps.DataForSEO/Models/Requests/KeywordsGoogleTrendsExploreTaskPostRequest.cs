using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class KeywordsGoogleTrendsExploreTaskPostRequest
{
    [Display("Keywords", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("keywords")]
    public List<string>? Keywords { get; set; }

    [Display("Keywords file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? KeywordsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsGoogleTrendsExploreTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsGoogleTrendsExploreTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Type", Description = "type of element")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Category code", Description = "google trends search category required field if you don't specify `keywords` if you don't specify `keywords`, the value of this field must be greater than `0` if you specify `keywords` and don't specify this field, the 0 value will be applied by default and the search will be carried out across all available categories you can receive the")]
    [JsonProperty("category_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsGoogleTrendsExploreTaskPostCategoryCodeHandler))]
    public string CategoryCode { get; set; } = string.Empty;

    [Display("Date from", Description = "starting date of the time range optional field if you don't specify this field, the current day and month of the preceding year will be used by default minimal value for the web type: 2004-01-01 minimal value for other types: 2008-01-01 date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Time range", Description = "preset time ranges optional field if you specify date_from or date_to parameters, this field will be ignored when setting a task possible values for all type parameters: past_hour , past_4_hours , past_day , past_7_days , past_30_days , past_90_days , past_12_months , past_5_years possible values for web only: 2004_present possible values")]
    [JsonProperty("time_range")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.KeywordsGoogleTrendsExploreTaskPostTimeRangeCatalogue))]
    public string? TimeRange { get; set; }

    [Display("Item types", Description = "types of items returned optional field to speed up the execution of the request, specify one item at a time; possible values: \"google_trends_graph\" , \"google_trends_map\" , \"google_trends_topics_list\" , \"google_trends_queries_list\" default value: \"google_trends_graph\" Note: to obtain google_trends_topics_list and google_trends_queries_list")]
    [JsonProperty("item_types")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.KeywordsGoogleTrendsExploreTaskPostItemTypesCatalogue))]
    public List<string>? ItemTypes { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request example: http://your-server.com/pingscript?id=$")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
