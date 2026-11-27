using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AiVisibilityLlmMentionsTargetMetricsLiveRequest
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
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTargetMetricsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTargetMetricsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Platform", Description = "target platform optional field possible values: chat_gpt , google Note: if the platform is not specified, the data is returned for both platforms Note #2: chat_gpt data is available for the United States and English only")]
    [JsonProperty("platform")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PlatformOptions18))]
    public string? Platform { get; set; }

    [Display("Initial dataset filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of filter expressions applied before aggregation optional field you can use this array to filter expressions applied to the raw mentions database before aggregation to limit ")]
    [JsonProperty("initial_dataset_filters")]
    public string? InitialDatasetFiltersJson { get; set; }

    [Display("Internal list limit", Description = "maximum number of elements within internal arrays optional field you can use this field to limit the number of elements within the following arrays: sources_domain search_results_domain minimum value: 1 maximum value: 10 default value: 10")]
    [JsonProperty("internal_list_limit")]
    public long? InternalListLimit { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
