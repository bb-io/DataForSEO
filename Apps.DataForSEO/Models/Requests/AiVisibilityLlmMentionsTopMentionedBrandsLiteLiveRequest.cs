using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveRequest
{
    [Display("Target JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of objects containing target entities required field you can specify up to 10 entities (objects) in the target field one target entity can contain either one domain or one ke")]
    [JsonProperty("target")]
    public string? TargetJson { get; set; }

    [Display("Target domains", Description = "Convenient include targets. For mixed scopes, exclusions or matching rules, use Target JSON instead.")]
    public List<string>? TargetDomains { get; set; }

    [Display("Target keywords", Description = "Convenient include targets. For mixed scopes, exclusions or matching rules, use Target JSON instead.")]
    public List<string>? TargetKeywords { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTopMentionedBrandsLiteLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Platform", Description = "target platform optional field possible values: chat_gpt , google default value: google Note: data specific to brand entities is available for chat_gpt only; Note #2: chat_gpt data is available for the United States and English only")]
    [JsonProperty("platform")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PlatformOptions18))]
    public string? Platform { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Initial dataset filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of filter expressions applied before aggregation optional field you can use this array to filter expressions applied to the raw mentions database before aggregation to limit ")]
    [JsonProperty("initial_dataset_filters")]
    public string? InitialDatasetFiltersJson { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: sources_domain , search_results_domain , brand_entities_title , brand_entities_category minimum value: 1 maximum value: 10 default value: 5")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"ai_search_volume,desc\"] Note: you can set ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Include brands", Description = "array of brands to include in the response optional field if specified, only the listed brands will be returned in the items array example: [\"BMW\",\"Audi\"]")]
    [JsonProperty("include_brands")]
    public List<string>? IncludeBrands { get; set; }

    [Display("Exclude brands", Description = "array of brands to exclude from the response optional field if specified, the listed brands will be omitted from the items array example: [\"BMW\",\"Audi\"]")]
    [JsonProperty("exclude_brands")]
    public List<string>? ExcludeBrands { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
