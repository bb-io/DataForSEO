using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class ContentCategoryTrendsLiveRequest
{
    [Display("Category code", Description = "target category code required field to obtain a full list of available categories, refer to the Categories endpoint")]
    [JsonProperty("category_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.ContentCategoryTrendsLiveCategoryCodeHandler))]
    public string CategoryCode { get; set; } = string.Empty;

    [Display("Page type", Description = "target page types optional field use this parameter to filter the dataset by page types possible values: \"ecommerce\" , \"news\" , \"blogs\" , \"message-boards\" , \"organization\"")]
    [JsonProperty("page_type")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.ContentCategoryTrendsLivePageTypeCatalogue))]
    public List<string>? PageType { get; set; }

    [Display("Search mode", Description = "results grouping type optional field possible grouping types: as_is - returns data on all citations for the target category_code one_per_domain - returns data on one citation of the category_code per domain default value: as_is")]
    [JsonProperty("search_mode")]
    public string? SearchMode { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: top_domains text_categories page_categories countries languages default value: 1 maximum value: 20")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Date from", Description = "starting date of the time range required field minimum value: 2022-10-31 date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_from")]
    public DateTime DateFrom { get; set; }

    [Display("Date to", Description = "ending date of the time range optional field if you don't specify this field, today's date will be used by default date format: \"yyyy-mm-dd\" example: \"2019-01-15\"")]
    [JsonProperty("date_to")]
    public DateTime? DateTo { get; set; }

    [Display("Date group", Description = "time range which will be used to group the results optional field default value: month possible values: day , week , month")]
    [JsonProperty("date_group")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.DateGroupOptions24))]
    public string? DateGroup { get; set; }

    [Display("Initial dataset filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. initial dataset filtering parameters optional field initial filtering parameters that apply to fields in the Search endpoint ; you can add several filters at once (8 filters maximu")]
    [JsonProperty("initial_dataset_filters")]
    public string? InitialDatasetFiltersJson { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on a 0\u20131000 scale default value: one_thous")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
