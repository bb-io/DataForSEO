using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleImagesLiveHtmlRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character '+' will be decoded to a space character) if you need to use the \"%\" character for your keyword , please specify it as \"%25\"; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; if this f")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleImagesLiveHtmlLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleImagesLiveHtmlLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 100 max value: 200 Your account will be billed per each SERP containing up to 100 results; Setting depth above 100 may result in additional charges if the search engine returns more than 100 results; If the specified depth is higher than the number of results in the res")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("OS", Description = "device operating system optional field note that this API provides results for desktop only choose from the following values: windows , macos default value: windows")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.OsOptions5))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Max crawl pages", Description = "page crawl limit optional field number of search results pages to crawl max value: 100 Note: the max_crawl_pages and depth parameters complement each other; learn more at our help center")]
    [JsonProperty("max_crawl_pages")]
    public long? MaxCrawlPages { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field get the list of available parameters and additional details here")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }

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
