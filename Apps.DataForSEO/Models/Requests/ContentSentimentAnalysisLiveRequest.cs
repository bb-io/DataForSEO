using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class ContentSentimentAnalysisLiveRequest
{
    [Display("Keyword", Description = "target keyword required field UTF-8 encoding the keywords will be converted to a lowercase format; Note: to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes; example: \"keyword\": \"\\\"tesla palo alto\\\"\" learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this He")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Keyword fields JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. target keyword fields and target keywords optional field use this parameter to filter the dataset by keywords that certain fields should contain; fields you can specify: title, mai")]
    [JsonProperty("keyword_fields")]
    public string? KeywordFieldsJson { get; set; }

    [Display("Page type", Description = "target page types optional field use this parameter to filter the dataset by page types possible values: \"ecommerce\", \"news\", \"blogs\", \"message-boards\", \"organization\"")]
    [JsonProperty("page_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ContentSentimentAnalysisLivePageTypeCatalogue))]
    public List<string>? PageType { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: top_domains text_categories page_categories countries languages default value: 1 maximum value: 20")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Positive connotation threshold", Description = "positive connotation threshold optional field specified as the probability index threshold for positive sentiment related to the citation content if you specify this field, connotation_types object in the response will only contain data on citations with positive sentiment probability more than or equal to the specified value possible val")]
    [JsonProperty("positive_connotation_threshold")]
    public double? PositiveConnotationThreshold { get; set; }

    [Display("Sentiments connotation threshold", Description = "sentiment connotation threshold optional field specified as the probability index threshold for sentiment connotations related to the citation content if you specify this field, sentiment_connotations object in the response will only contain data on citations where the probability per each sentiment is more than or equal to the specified ")]
    [JsonProperty("sentiments_connotation_threshold")]
    public double? SentimentsConnotationThreshold { get; set; }

    [Display("Initial dataset filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. initial dataset filtering parameters optional field initial filtering parameters that apply to fields in the Search endpoint you can add several filters at once (8 filters maximum)")]
    [JsonProperty("initial_dataset_filters")]
    public string? InitialDatasetFiltersJson { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on a 0\u20131000 scale default value: one_thous")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ContentSentimentAnalysisLiveRankScaleCatalogue))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
