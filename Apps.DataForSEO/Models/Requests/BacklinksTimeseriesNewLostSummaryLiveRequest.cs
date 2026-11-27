using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksTimeseriesNewLostSummaryLiveRequest
{
    [Display("Target", Description = "domain to get data for required field a domain should be specified without https:// and www. example: \"forbes.com\"")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Date from", Description = "starting date of the time range optional field this field indicates the date which will be used as a threshold for new and lost backlinks and referring domains; the backlinks and referring domains that appeared in our index after the specified date will be considered as new; the backlinks and referring domains that weren't found after the")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, the today's date will be used by default minimum value shouldn't preceed the date specified in the date_from maximum value: today's date date format: \"yyyy-mm-dd\" example: \"2021-01-15\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Group range", Description = "time range which will be used to group the results optional field default value: month possible values: day , week , month , year note: for day , we will return items corresponding to all dates between and including date_from and date_to ; for week / month / year , we will return items corresponding to full weeks/months/years, where each ")]
    [JsonProperty("group_range")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.GroupRangeOptions17))]
    public string? GroupRange { get; set; }

    [Display("Include subdomains", Description = "indicates if the subdomains of the target will be included in the search optional field if set to false , the subdomains will be ignored default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
