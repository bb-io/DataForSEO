using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataGoogleAdsSearchVolumeTaskGetResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Spell")]
    [JsonProperty("spell")]
    public string? Spell { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Search partners")]
    [JsonProperty("search_partners")]
    public bool? SearchPartners { get; set; }

    [Display("Competition")]
    [JsonProperty("competition")]
    public string? Competition { get; set; }

    [Display("Competition index")]
    [JsonProperty("competition_index")]
    public long? CompetitionIndex { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Low top of page bid")]
    [JsonProperty("low_top_of_page_bid")]
    public double? LowTopOfPageBid { get; set; }

    [Display("High top of page bid")]
    [JsonProperty("high_top_of_page_bid")]
    public double? HighTopOfPageBid { get; set; }

    [Display("CPC")]
    [JsonProperty("cpc")]
    public double? Cpc { get; set; }

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];
}
