using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class KeywordsGoogleAdsSearchVolumeTaskPostRequest
{
    [Display("Keywords", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("keywords")]
    public List<string>? Keywords { get; set; }

    [Display("Keywords file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? KeywordsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsGoogleAdsSearchVolumeTaskPostLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Location coordinate", Description = "GPS coordinates of a location optional field if you do not indicate the location, you will receive worldwide results, i.e., for all available locations; if you use this field, you don't need to specify location_name or location_code ; location_coordinate parameter should be specified in the \"latitude,longitude\" format; the data will be pr")]
    [JsonProperty("location_coordinate")]
    public string? LocationCoordinate { get; set; }

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsGoogleAdsSearchVolumeTaskPostLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Search partners", Description = "include Google search partners optional field if you specify true , the results will be delivered for owned, operated, and syndicated networks across Google and partner sites that host Google search; default value: false - results are returned for Google search sites")]
    [JsonProperty("search_partners")]
    public bool? SearchPartners { get; set; }

    [Display("Date from", Description = "starting date of the time range optional field date format: \"yyyy-mm-dd\" minimal value: 4 years from the current date by default, data is returned for the past 12 months; Note : the indicated date cannot be greater than that specified in date_to and/or yesterday's date; if Status endpoint returns false in the actual_data field, date_from ")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field Note: the indicated date cannot be greater than the past month, Google Ads does not return data on the current month; if you don't specify this field, yesterday's date will be used by default date format: \"yyyy-mm-dd\" example: \"2022-11-30\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Include adult keywords", Description = "include keywords associated with adult content optional field if set to_ true , adult keywords will be included in the response default value:_ false note _that the API may return no data for such keywords due to_ Google Ads restrictions n")]
    [JsonProperty("include_adult_keywords")]
    public bool? IncludeAdultKeywords { get; set; }

    [Display("Sort by", Description = "results sorting parameters optional field use these parameters to sort the results by relevance , search_volume , competition_index , low_top_of_page_bid , or high_top_of_page_bid in the descending order default value: relevance")]
    [JsonProperty("sort_by")]
    public string? SortBy { get; set; }

    [Display("Postback URL", Description = "URL for sending task results optional field once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: ht")]
    [JsonProperty("postback_url")]
    public string? PostbackUrl { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request example: http://your-server.com/pingscript?id=$")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data array of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
