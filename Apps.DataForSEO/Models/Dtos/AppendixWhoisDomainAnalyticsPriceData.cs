using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixWhoisDomainAnalyticsPriceData
{
    [Display("Overview")]
    [JsonProperty("overview")]
    public AppendixBingKeywordsDataPriceDataInfo? Overview { get; set; }
}
