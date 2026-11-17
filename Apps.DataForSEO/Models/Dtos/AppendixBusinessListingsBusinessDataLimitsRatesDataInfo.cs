using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBusinessListingsBusinessDataLimitsRatesDataInfo
{
    [Display("Search")]
    [JsonProperty("search")]
    public AppendixInfo? Search { get; set; }

    [Display("Categories aggregation")]
    [JsonProperty("categories_aggregation")]
    public AppendixInfo? CategoriesAggregation { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public double? Categories { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }
}
