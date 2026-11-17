using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDataForSEOLabsLimitsRatesDataInfo
{
    [Display("Related keywords")]
    [JsonProperty("related_keywords")]
    public AppendixInfo? RelatedKeywords { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public double? LocationsAndLanguages { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public double? Categories { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public double? Errors { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public double? AvailableFilters { get; set; }

    [Display("Product competitors")]
    [JsonProperty("product_competitors")]
    public AppendixInfo? ProductCompetitors { get; set; }

    [Display("Product keyword intersections")]
    [JsonProperty("product_keyword_intersections")]
    public AppendixInfo? ProductKeywordIntersections { get; set; }

    [Display("Product rank overview")]
    [JsonProperty("product_rank_overview")]
    public AppendixInfo? ProductRankOverview { get; set; }

    [Display("Ranked keywords")]
    [JsonProperty("ranked_keywords")]
    public AppendixInfo? RankedKeywords { get; set; }

    [Display("SERP competitors")]
    [JsonProperty("serp_competitors")]
    public AppendixInfo? SerpCompetitors { get; set; }

    [Display("Subdomains")]
    [JsonProperty("subdomains")]
    public AppendixInfo? Subdomains { get; set; }

    [Display("Relevant pages")]
    [JsonProperty("relevant_pages")]
    public AppendixInfo? RelevantPages { get; set; }

    [Display("Competitors domain")]
    [JsonProperty("competitors_domain")]
    public AppendixInfo? CompetitorsDomain { get; set; }

    [Display("Domain rank overview")]
    [JsonProperty("domain_rank_overview")]
    public AppendixInfo? DomainRankOverview { get; set; }

    [Display("Domain intersection")]
    [JsonProperty("domain_intersection")]
    public AppendixInfo? DomainIntersection { get; set; }

    [Display("Page intersection")]
    [JsonProperty("page_intersection")]
    public AppendixInfo? PageIntersection { get; set; }

    [Display("Bulk traffic estimation")]
    [JsonProperty("bulk_traffic_estimation")]
    public AppendixInfo? BulkTrafficEstimation { get; set; }

    [Display("Bulk keyword difficulty")]
    [JsonProperty("bulk_keyword_difficulty")]
    public AppendixInfo? BulkKeywordDifficulty { get; set; }

    [Display("Bulk search volume")]
    [JsonProperty("bulk_search_volume")]
    public AppendixInfo? BulkSearchVolume { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixInfo? KeywordsForSite { get; set; }

    [Display("Keyword suggestions")]
    [JsonProperty("keyword_suggestions")]
    public AppendixInfo? KeywordSuggestions { get; set; }

    [Display("Keyword ideas")]
    [JsonProperty("keyword_ideas")]
    public AppendixInfo? KeywordIdeas { get; set; }

    [Display("Categories for domain")]
    [JsonProperty("categories_for_domain")]
    public AppendixInfo? CategoriesForDomain { get; set; }

    [Display("Domain metrics by categories")]
    [JsonProperty("domain_metrics_by_categories")]
    public AppendixInfo? DomainMetricsByCategories { get; set; }

    [Display("Top searches")]
    [JsonProperty("top_searches")]
    public AppendixInfo? TopSearches { get; set; }

    [Display("Domain whois overview")]
    [JsonProperty("domain_whois_overview")]
    public AppendixInfo? DomainWhoisOverview { get; set; }

    [Display("Historical rank overview")]
    [JsonProperty("historical_rank_overview")]
    public AppendixInfo? HistoricalRankOverview { get; set; }

    [Display("Keywords for categories")]
    [JsonProperty("keywords_for_categories")]
    public AppendixInfo? KeywordsForCategories { get; set; }

    [Display("Historical serps")]
    [JsonProperty("historical_serps")]
    public AppendixInfo? HistoricalSerps { get; set; }

    [Display("App competitors")]
    [JsonProperty("app_competitors")]
    public AppendixInfo? AppCompetitors { get; set; }

    [Display("Keywords for app")]
    [JsonProperty("keywords_for_app")]
    public AppendixInfo? KeywordsForApp { get; set; }

    [Display("App intersection")]
    [JsonProperty("app_intersection")]
    public AppendixInfo? AppIntersection { get; set; }

    [Display("Bulk app metrics")]
    [JsonProperty("bulk_app_metrics")]
    public AppendixInfo? BulkAppMetrics { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public double? IdList { get; set; }

    [Display("Search intent")]
    [JsonProperty("search_intent")]
    public AppendixInfo? SearchIntent { get; set; }

    [Display("Historical bulk traffic estimation")]
    [JsonProperty("historical_bulk_traffic_estimation")]
    public AppendixInfo? HistoricalBulkTrafficEstimation { get; set; }

    [Display("Categories for keywords")]
    [JsonProperty("categories_for_keywords")]
    public AppendixInfo? CategoriesForKeywords { get; set; }

    [Display("Keyword overview")]
    [JsonProperty("keyword_overview")]
    public AppendixInfo? KeywordOverview { get; set; }

    [Display("Historical keyword data")]
    [JsonProperty("historical_keyword_data")]
    public AppendixInfo? HistoricalKeywordData { get; set; }
}
