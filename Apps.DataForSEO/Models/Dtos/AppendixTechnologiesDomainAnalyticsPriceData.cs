using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTechnologiesDomainAnalyticsPriceData
{
    [Display("Languages")]
    [JsonProperty("languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public AppendixTaskKeywordsDataPriceDataInfo? Locations { get; set; }

    [Display("Technologies")]
    [JsonProperty("technologies")]
    public AppendixTaskKeywordsDataPriceDataInfo? Technologies { get; set; }

    [Display("Aggregation technologies")]
    [JsonProperty("aggregation_technologies")]
    public AppendixBingKeywordsDataPriceDataInfo? AggregationTechnologies { get; set; }

    [Display("Domains by HTML terms")]
    [JsonProperty("domains_by_html_terms")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainsByHtmlTerms { get; set; }

    [Display("Domains by technology")]
    [JsonProperty("domains_by_technology")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainsByTechnology { get; set; }

    [Display("Domain technologies")]
    [JsonProperty("domain_technologies")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainTechnologies { get; set; }

    [Display("Technologies summary")]
    [JsonProperty("technologies_summary")]
    public AppendixBingKeywordsDataPriceDataInfo? TechnologiesSummary { get; set; }

    [Display("Technology stats")]
    [JsonProperty("technology_stats")]
    public AppendixBingKeywordsDataPriceDataInfo? TechnologyStats { get; set; }
}
