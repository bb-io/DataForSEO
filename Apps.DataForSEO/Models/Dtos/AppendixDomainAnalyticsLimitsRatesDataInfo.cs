using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDomainAnalyticsLimitsRatesDataInfo
{
    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public double? TasksReady { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Whois")]
    [JsonProperty("whois")]
    public AppendixWhoisDomainAnalyticsLimitsRatesDataInfo? Whois { get; set; }

    [Display("Technologies")]
    [JsonProperty("technologies")]
    public AppendixTechnologiesDomainAnalyticsLimitsRatesDataInfo? Technologies { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }
}
