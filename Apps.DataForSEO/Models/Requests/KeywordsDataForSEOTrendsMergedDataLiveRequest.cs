using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class KeywordsDataForSEOTrendsMergedDataLiveRequest
{
    [Display("Keywords", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("keywords")]
    public List<string>? Keywords { get; set; }

    [Display("Keywords file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? KeywordsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.KeywordsDataForSEOTrendsMergedDataLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Type", Description = "type of element")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Date from", Description = "starting date of the time range optional field if you don't specify this field, the current day and month of the preceding year will be used by default minimal value for the web type: 2004-01-01 minimal value for other types: 2008-01-01 date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Time range", Description = "preset time ranges optional field if you specify date_from or date_to parameters, this field will be ignored when setting a task possible values for all type parameters: past_4_hours , past_day , past_7_days , past_30_days , past_90_days , past_12_months , past_5_years")]
    [JsonProperty("time_range")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.KeywordsDataForSEOTrendsMergedDataLiveTimeRangeCatalogue))]
    public string? TimeRange { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
