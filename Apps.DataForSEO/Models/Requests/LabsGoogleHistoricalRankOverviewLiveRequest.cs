using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleHistoricalRankOverviewLiveRequest
{
    [Display("Target", Description = "domain required field the domain name of the target website the domain should be specified without https:// and www.")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleHistoricalRankOverviewLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleHistoricalRankOverviewLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Date from", Description = "starting date of the time range optional field if you don't specify this field, the data will be provided for the previous 6 months minimal possible value: 2020-10-01 date format: \"yyyy-mm-dd\"")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default date format: \"yyyy-mm-dd\" example: \"2021-04-01\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Correlate", Description = "correlate data with previously obtained datasets optional field default value: true if you use this parameter, our system will correlate data you obtain now with previously obtained datasets this parameter is intended to mitigate any inconsistencies that may result from changes to our database we recommend always setting correlate to true")]
    [JsonProperty("correlate")]
    public bool? Correlate { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to true , only data based on core keywords will be returned, data for all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to true , you will receive clickstream_etv , clickstream_gender_distribution , and clickstream_age_distribution fields with clickstream data in the response; default value: false ; Note: historical clickstream data is available from")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
