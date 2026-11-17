using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class KeywordsDataBingSearchVolumeTaskGetResultInfo
{
    [Display("Keyword")]
    [JsonProperty("keyword")]
    public string? Keyword { get; set; }

    [Display("Location code")]
    [JsonProperty("location_code")]
    public long? LocationCode { get; set; }

    [Display("Language code")]
    [JsonProperty("language_code")]
    public string? LanguageCode { get; set; }

    [Display("Search partners")]
    [JsonProperty("search_partners")]
    public bool? SearchPartners { get; set; }

    [Display("Device")]
    [JsonProperty("device")]
    public string? Device { get; set; }

    [Display("Competition")]
    [JsonProperty("competition")]
    public double? Competition { get; set; }

    [Display("CPC")]
    [JsonProperty("cpc")]
    public double? Cpc { get; set; }

    [Display("Search volume")]
    [JsonProperty("search_volume")]
    public long? SearchVolume { get; set; }

    [Display("Categories")]
    [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Categories { get; set; } = [];

    [Display("Monthly searches")]
    [JsonProperty("monthly_searches", NullValueHandling = NullValueHandling.Ignore)]
    public List<MonthlySearchesInfo> MonthlySearches { get; set; } = [];
}
