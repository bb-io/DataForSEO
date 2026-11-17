using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AiVisibilityLlmMentionsSearchMentionsLiveRequest
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
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsSearchMentionsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsSearchMentionsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Platform", Description = "target platform optional field possible values: chat_gpt , google Note: if the platform is not specified, the data is returned for both platforms Note #2: chat_gpt data is available for the United States and English only")]
    [JsonProperty("platform")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PlatformOptions18))]
    public string? Platform { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"ai_search_volume,desc\"] Note: you can set ")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
