using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixDataForSEOLabsPriceData
{
    [Display("App competitors")]
    [JsonProperty("app_competitors")]
    public AppendixBingKeywordsDataPriceDataInfo? AppCompetitors { get; set; }

    [Display("App intersection")]
    [JsonProperty("app_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? AppIntersection { get; set; }

    [Display("Bulk app metrics")]
    [JsonProperty("bulk_app_metrics")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkAppMetrics { get; set; }

    [Display("Bulk keyword difficulty")]
    [JsonProperty("bulk_keyword_difficulty")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkKeywordDifficulty { get; set; }

    [Display("Bulk search volume")]
    [JsonProperty("bulk_search_volume")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkSearchVolume { get; set; }

    [Display("Bulk traffic estimation")]
    [JsonProperty("bulk_traffic_estimation")]
    public AppendixBingKeywordsDataPriceDataInfo? BulkTrafficEstimation { get; set; }

    [Display("Categories")]
    [JsonProperty("categories")]
    public AppendixTaskKeywordsDataPriceDataInfo? Categories { get; set; }

    [Display("Categories for domain")]
    [JsonProperty("categories_for_domain")]
    public AppendixBingKeywordsDataPriceDataInfo? CategoriesForDomain { get; set; }

    [Display("Categories for keywords")]
    [JsonProperty("categories_for_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? CategoriesForKeywords { get; set; }

    [Display("Competitors domain")]
    [JsonProperty("competitors_domain")]
    public AppendixBingKeywordsDataPriceDataInfo? CompetitorsDomain { get; set; }

    [Display("Available filters")]
    [JsonProperty("available_filters")]
    public AppendixTaskKeywordsDataPriceDataInfo? AvailableFilters { get; set; }

    [Display("Domain intersection")]
    [JsonProperty("domain_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainIntersection { get; set; }

    [Display("Domain metrics by categories")]
    [JsonProperty("domain_metrics_by_categories")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainMetricsByCategories { get; set; }

    [Display("Domain rank overview")]
    [JsonProperty("domain_rank_overview")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainRankOverview { get; set; }

    [Display("Domain whois overview")]
    [JsonProperty("domain_whois_overview")]
    public AppendixBingKeywordsDataPriceDataInfo? DomainWhoisOverview { get; set; }

    [Display("Errors")]
    [JsonProperty("errors")]
    public AppendixTaskKeywordsDataPriceDataInfo? Errors { get; set; }

    [Display("Historical bulk traffic estimation")]
    [JsonProperty("historical_bulk_traffic_estimation")]
    public AppendixBingKeywordsDataPriceDataInfo? HistoricalBulkTrafficEstimation { get; set; }

    [Display("Historical keyword data")]
    [JsonProperty("historical_keyword_data")]
    public AppendixBingKeywordsDataPriceDataInfo? HistoricalKeywordData { get; set; }

    [Display("Historical rank overview")]
    [JsonProperty("historical_rank_overview")]
    public AppendixBingKeywordsDataPriceDataInfo? HistoricalRankOverview { get; set; }

    [Display("Historical serps")]
    [JsonProperty("historical_serps")]
    public AppendixBingKeywordsDataPriceDataInfo? HistoricalSerps { get; set; }

    [Display("ID list")]
    [JsonProperty("id_list")]
    public AppendixTaskKeywordsDataPriceDataInfo? IdList { get; set; }

    [Display("Keyword ideas")]
    [JsonProperty("keyword_ideas")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordIdeas { get; set; }

    [Display("Keyword overview")]
    [JsonProperty("keyword_overview")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordOverview { get; set; }

    [Display("Keywords for app")]
    [JsonProperty("keywords_for_app")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForApp { get; set; }

    [Display("Keywords for categories")]
    [JsonProperty("keywords_for_categories")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForCategories { get; set; }

    [Display("Keywords for site")]
    [JsonProperty("keywords_for_site")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordsForSite { get; set; }

    [Display("Keyword suggestions")]
    [JsonProperty("keyword_suggestions")]
    public AppendixBingKeywordsDataPriceDataInfo? KeywordSuggestions { get; set; }

    [Display("Locations and languages")]
    [JsonProperty("locations_and_languages")]
    public AppendixTaskKeywordsDataPriceDataInfo? LocationsAndLanguages { get; set; }

    [Display("Page intersection")]
    [JsonProperty("page_intersection")]
    public AppendixBingKeywordsDataPriceDataInfo? PageIntersection { get; set; }

    [Display("Product competitors")]
    [JsonProperty("product_competitors")]
    public AppendixBingKeywordsDataPriceDataInfo? ProductCompetitors { get; set; }

    [Display("Product keyword intersections")]
    [JsonProperty("product_keyword_intersections")]
    public AppendixBingKeywordsDataPriceDataInfo? ProductKeywordIntersections { get; set; }

    [Display("Product rank overview")]
    [JsonProperty("product_rank_overview")]
    public AppendixBingKeywordsDataPriceDataInfo? ProductRankOverview { get; set; }

    [Display("Ranked keywords")]
    [JsonProperty("ranked_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? RankedKeywords { get; set; }

    [Display("Related keywords")]
    [JsonProperty("related_keywords")]
    public AppendixBingKeywordsDataPriceDataInfo? RelatedKeywords { get; set; }

    [Display("Relevant pages")]
    [JsonProperty("relevant_pages")]
    public AppendixBingKeywordsDataPriceDataInfo? RelevantPages { get; set; }

    [Display("Search intent")]
    [JsonProperty("search_intent")]
    public AppendixBingKeywordsDataPriceDataInfo? SearchIntent { get; set; }

    [Display("SERP competitors")]
    [JsonProperty("serp_competitors")]
    public AppendixBingKeywordsDataPriceDataInfo? SerpCompetitors { get; set; }

    [Display("Subdomains")]
    [JsonProperty("subdomains")]
    public AppendixBingKeywordsDataPriceDataInfo? Subdomains { get; set; }

    [Display("Top searches")]
    [JsonProperty("top_searches")]
    public AppendixBingKeywordsDataPriceDataInfo? TopSearches { get; set; }
}
