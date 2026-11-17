using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentAnalysisCategoryTrendsLiveResultInfo
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Total count")]
    [JsonProperty("total_count")]
    public long? TotalCount { get; set; }

    [Display("Rank")]
    [JsonProperty("rank")]
    public long? Rank { get; set; }

    [Display("Top domains")]
    [JsonProperty("top_domains", NullValueHandling = NullValueHandling.Ignore)]
    public List<TopDomainInfo> TopDomains { get; set; } = [];

    [Display("Sentiment connotations")]
    [JsonProperty("sentiment_connotations")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? SentimentConnotations { get; set; }

    [Display("Connotation types")]
    [JsonProperty("connotation_types")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? ConnotationTypes { get; set; }

    [Display("Text categories")]
    [JsonProperty("text_categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContentAnalysisCategoriesInfo> TextCategories { get; set; } = [];

    [Display("Page categories")]
    [JsonProperty("page_categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContentAnalysisCategoriesInfo> PageCategories { get; set; } = [];

    [Display("Page types")]
    [JsonProperty("page_types")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? PageTypes { get; set; }

    [Display("Countries")]
    [JsonProperty("countries")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Countries { get; set; }

    [Display("Languages")]
    [JsonProperty("languages")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Languages { get; set; }
}
