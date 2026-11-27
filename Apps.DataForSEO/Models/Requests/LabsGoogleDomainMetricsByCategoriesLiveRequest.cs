using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleDomainMetricsByCategoriesLiveRequest
{
    [Display("Category codes", Description = "product and service categories required field The maximum number of categories you can specify: 5 you can download the full list of possible categories")]
    [JsonProperty("category_codes")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleDomainMetricsByCategoriesLiveCategoryCodesHandler))]
    public List<string> CategoryCodes { get; set; } = [];

    [Display("First date", Description = "first date of comparison period required field first date for which domain metrics will be provided; date format: \"yyyy-mm-dd\" ; example: \"2021-06-01\" ; the list available dates is available through the available history endpoint ; Note: first_date cannot be greater than today's date; Also note: the dates specified in first_date and secon")]
    [JsonProperty("first_date")]
    public string FirstDate { get; set; } = string.Empty;

    [Display("Second date", Description = "second date of comparison period required field second date for which domain metrics will be provided; date format: \"yyyy-mm-dd\" ; example: \"2021-10-01\" ; the list available dates is available through the available history endpoint ; Note: second_date cannot be greater than today's date; Also note: the dates specified in first_date and se")]
    [JsonProperty("second_date")]
    public string SecondDate { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleDomainMetricsByCategoriesLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleDomainMetricsByCategoriesLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Item types", Description = "display results by item type optional field indicates the type of search results included in the response; Note: if the item_types array contains item types that are different from the organic object, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search res")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Top categories count", Description = "number of additional domain categories optional field by using this parameter, you can receive domains relevant to additional categories that are not specified in category_codes above; to learn more about the parameter, please refer to this help center article; by default, top_categories_count is equal to the number of categories specifie")]
    [JsonProperty("top_categories_count")]
    public long? TopCategoriesCount { get; set; }

    [Display("Include subdomains", Description = "return subdomains in the API response optional field if false , the API response will contain main_domain only; if true , the API will return main_domain plus its subdomains (if available); default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Etv min", Description = "minimum current organic ETV of the domain optional field if specified, the API will return only domains with organic_etv greater than the specified value")]
    [JsonProperty("etv_min")]
    public long? EtvMin { get; set; }

    [Display("Etv max", Description = "maximum current organic ETV of the domain optional field if specified, the API will return only domains with organic_etv lesser than the specified value")]
    [JsonProperty("etv_max")]
    public long? EtvMax { get; set; }

    [Display("Correlate", Description = "correlate data with previously obtained datasets optional field default value: true ; if you use this parameter, our system will correlate data you obtain now with previously obtained datasets; this parameter is intended to mitigate any inconsistencies that may result from changes to our database; Note: we do not recommend setting correla")]
    [JsonProperty("correlate")]
    public bool? Correlate { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) ; you should set a logical operator and , or between the conditions the")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results; default rule: [\"organic_etv,desc\"] ; possible sorting types: asc - results will be sorted in ascending order desc - results will be sorted in descending order; you should use a comma to set up a sorting type; example: [\"organic_co")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 ; you can use this parameter to identify the task and match it with the result; you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
