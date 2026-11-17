using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpYoutubeOrganicLiveAdvancedRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d; learn mor")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYoutubeOrganicLiveAdvancedLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYoutubeOrganicLiveAdvancedLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Device", Description = "device type optional field return results for a specific device type available values: desktop , mobile")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public string? Device { get; set; }

    [Display("Block depth", Description = "parsing depth optional field number of blocks of results in SERP default value: 20 max value: 200 Note: your account will be billed per each SERP containing up to 20 results; thus, setting a block depth above 20 may result in additional charges if the search engine returns more than 20 results; if the specified block depth is higher than ")]
    [JsonProperty("block_depth")]
    public long? BlockDepth { get; set; }

    [Display("OS", Description = "device operating system optional field if you specify desktop in the device field, choose from the following values: windows , macos default value: windows if you specify mobile in the device field, choose from the following values: android , ios default value: android")]
    [JsonProperty("os")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpYoutubeOrganicLiveAdvancedOsCatalogueHandler))]
    public string? Os { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Search param", Description = "additional parameters of the search query optional field example: sp=EgIQAg%253D%253D")]
    [JsonProperty("search_param")]
    public string? SearchParam { get; set; }
}
