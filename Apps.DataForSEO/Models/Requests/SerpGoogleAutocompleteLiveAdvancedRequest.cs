using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleAutocompleteLiveAdvancedRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; learn mor")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAutocompleteLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleAutocompleteLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Cursor pointer", Description = "search bar cursor pointer optional field the horizontal numerical position of the cursor pointer within the keyword in the search bar; by modifying the position of the cursor pointer, you will obtain different autocomplete suggestions for the same seed keyword; minimal value: 0 default value: the number of the last character of the specif")]
    [JsonProperty("cursor_pointer")]
    public long? CursorPointer { get; set; }

    [Display("Client", Description = "search client for autocomplete optional field autocomplete results may differ depending on the search client; possible values: chrome \u2014 used when google search is opened in google chrome; chrome-omni \u2014 used in the address bar in chrome; gws-wiz \u2014 used in google search home page; gws-wiz-serp \u2014 used in google search engine results page; sa")]
    [JsonProperty("client")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ClientOptions8))]
    public string? Client { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
