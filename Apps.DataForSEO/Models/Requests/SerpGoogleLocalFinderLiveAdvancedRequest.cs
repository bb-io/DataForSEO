using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpGoogleLocalFinderLiveAdvancedRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d learn more")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleLocalFinderLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleLocalFinderLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "parsing depth optional field number of results in SERP default value: 10 max value: 100 Your account will be billed per each SERP containing up to 10 results; Setting depth above 10 may result in additional charges if the search engine returns more than 10 results respectively; If the specified depth is higher than the number of results i")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Resolve goto URLS", Description = "resolve goto redirect URLs optional field set to true to resolve goto redirect URLs in SERPs default value: false Note: this parameter adds up to 40 seconds to the turnaround time, with a maximum turnaround time of 260 seconds")]
    [JsonProperty("resolve_goto_urls")]
    public bool? ResolveGotoUrls { get; set; }

    [Display("Device", Description = "device type optional field return results for a specific device type can take the values: desktop , mobile default value: desktop")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpGoogleLocalFinderLiveAdvancedOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude,zoom\" format if \"zoom\" is not specified, 9z will be applied as a default value the max")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;
}
