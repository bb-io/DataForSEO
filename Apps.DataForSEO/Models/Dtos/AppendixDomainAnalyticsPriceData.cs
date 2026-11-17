using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDomainAnalyticsPriceData
{
    [Display("Whois")]
    [JsonProperty("whois")]
    public AppendixWhoisDomainAnalyticsPriceData? Whois { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Technologies")]
    [JsonProperty("technologies")]
    public AppendixTechnologiesDomainAnalyticsPriceData? Technologies { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("Tasks ready")]
    [JsonProperty("tasks_ready")]
    public AppendixTaskKeywordsDataPriceDataInfo? TasksReady { get; set; }
}
