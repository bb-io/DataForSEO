using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixWhoisDomainAnalyticsLimitsRatesDataInfo
{
    [Display("Overview")]
    [JsonProperty("overview")]
    public AppendixInfo? Overview { get; set; }
}
