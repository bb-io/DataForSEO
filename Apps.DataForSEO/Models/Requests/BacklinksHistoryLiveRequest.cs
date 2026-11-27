using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksHistoryLiveRequest
{
    [Display("Target", Description = "domain required field a domain should be specified without https:// and www.")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Date from", Description = "starting date of the time range optional field minimum value 2019-01-01 if you don't specify this field, the minimum value will be used by default date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank , domain_from_rank , and page_from_rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
