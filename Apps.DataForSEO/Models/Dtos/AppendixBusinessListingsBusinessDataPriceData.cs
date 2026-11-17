using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixBusinessListingsBusinessDataPriceData
{
    [Display("Categories")]
    [JsonProperty("categories")]
    public AppendixTaskKeywordsDataPriceDataInfo? Categories { get; set; }

    [Display("Categories aggregation")]
    [JsonProperty("categories_aggregation")]
    public AppendixBingKeywordsDataPriceDataInfo? CategoriesAggregation { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Search")]
    [JsonProperty("search")]
    public AppendixBingKeywordsDataPriceDataInfo? Search { get; set; }
}
