using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class ContentSearchLiveRequest
{
    [Display("Keyword", Description = "target keyword required field UTF-8 encoding the keywords will be converted to a lowercase format; Note : to match an exact phrase instead of a stand-alone keyword, use double quotes and backslashes; example: `\"keyword\": \"\\\"tesla palo alto\\\"\"` learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Keyword fields JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. target keyword fields and target keywords optional field use this parameter to filter the dataset by keywords that certain fields should contain; fields you can specify: title , ma")]
    [JsonProperty("keyword_fields")]
    public string? KeywordFieldsJson { get; set; }

    [Display("Page type", Description = "target page types optional field use this parameter to filter the dataset by page types possible values: \"ecommerce\" , \"news\" , \"blogs\" , \"message-boards\" , \"organization\"")]
    [JsonProperty("page_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ContentSearchLivePageTypeCatalogue))]
    public List<string>? PageType { get; set; }

    [Display("Search mode", Description = "results grouping type optional field possible grouping types: as_is - returns all citations for the target keyword one_per_domain - returns one citation of the keyword per domain default value: as_is")]
    [JsonProperty("search_mode")]
    public string? SearchMode { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"content_info.sentiment_connotations.anger,")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the domain_rank , and url_rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on a 0\u20131000 scale de")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
