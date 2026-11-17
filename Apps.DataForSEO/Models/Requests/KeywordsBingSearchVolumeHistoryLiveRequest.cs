using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class KeywordsBingSearchVolumeHistoryLiveRequest
{
    [Display("Keywords", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("keywords")]
    public List<string>? Keywords { get; set; }

    [Display("Keywords file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? KeywordsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsBingSearchVolumeHistoryLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Location coordinate", Description = "GPS coordinates of a location required field if you don't specify location_name or location_code if you use this field, you don't need to specify location_name or location_code location_coordinate parameter should be specified in the \"latitude,longitude\" format the data will be provided for the country the specified coordinates belong to ")]
    [JsonProperty("location_coordinate")]
    public string LocationCoordinate { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsBingSearchVolumeHistoryLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Device", Description = "device types optional field specify this field if you want to get the data for a particular device types possible values: mobile , desktop , tablet , non_smartphones default value: [\"mobile\", \"desktop\", \"tablet\", \"non_smartphones\"]")]
    [JsonProperty("device")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DeviceOptions2))]
    public List<string>? Device { get; set; }

    [Display("Period", Description = "aggregates the returned data to a certain time period optional field specify this field if you want to get the data in monthly, weekly or daily formatpossible values: monthly , weekly , daily monthly - returns data up to past 24 months weekly - returns data up to past 15 weeks daily - returns data up to past 45 days default value: monthly")]
    [JsonProperty("period")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PeriodOptions12))]
    public string? Period { get; set; }

    [Display("Date from", Description = "starting date of the time range optional field minimum value: 24 months back from today\u2019s date; if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior; if Status endpoint returns true in the actual_data field, date_from can be set to the last month and prior; date format: \"yyyy-m")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional fieldminimum value: two years back from today\u2019s date; maximum value: one day from today's date; date format: \"yyyy-mm-dd\" example: \"2020-03-15\" Note: we do not recommend using a custom time range Note 2: if date_from and date_to parameters are not specified, the data will be returned for the past 24 ")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
