using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixTechnologiesDomainAnalyticsLimitsRatesDataInfo
{
    [Display("Domain technologies")]
    [JsonProperty("domain_technologies")]
    public AppendixInfo? DomainTechnologies { get; set; }

    [Display("Domains by technology")]
    [JsonProperty("domains_by_technology")]
    public AppendixInfo? DomainsByTechnology { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    public double? Languages { get; set; }

    [Display("Locations")]
    [JsonProperty("locations")]
    public double? Locations { get; set; }

    [Display("Technologies")]
    [JsonProperty("technologies")]
    public double? Technologies { get; set; }

    [Display("Aggregation technologies")]
    [JsonProperty("aggregation_technologies")]
    public AppendixInfo? AggregationTechnologies { get; set; }

    [Display("Technologies summary")]
    [JsonProperty("technologies_summary")]
    public AppendixInfo? TechnologiesSummary { get; set; }

    [Display("Domains by HTML terms")]
    [JsonProperty("domains_by_html_terms")]
    public AppendixInfo? DomainsByHtmlTerms { get; set; }

    [Display("Technology stats")]
    [JsonProperty("technology_stats")]
    public AppendixInfo? TechnologyStats { get; set; }
}
