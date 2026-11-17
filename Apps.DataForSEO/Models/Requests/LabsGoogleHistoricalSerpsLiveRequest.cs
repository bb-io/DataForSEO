using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleHistoricalSerpsLiveRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 700 characters in the keyword field; all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character); if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Date from", Description = "starting date of the time range optional field if you don't specify this field, the API will return all SERPs collected for 365 days starting from the current datetime value; minimal possible value: 365 days from the current datetime value; date format: \"yyyy-mm-dd\"")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default; date format: \"yyyy-mm-dd\" ; example: \"2021-09-01\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleHistoricalSerpsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleHistoricalSerpsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
