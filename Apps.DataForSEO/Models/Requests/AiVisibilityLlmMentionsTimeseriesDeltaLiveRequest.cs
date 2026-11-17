using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AiVisibilityLlmMentionsTimeseriesDeltaLiveRequest
{
    [Display("Target JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of objects containing target entities required field you can specify up to 10 entities (objects) in the target field one target entity can contain either one domain or one ke")]
    [JsonProperty("target")]
    public string? TargetJson { get; set; }

    [Display("Target domains", Description = "Convenient include targets. For mixed scopes, exclusions or matching rules, use Target JSON instead.")]
    public List<string>? TargetDomains { get; set; }

    [Display("Target keywords", Description = "Convenient include targets. For mixed scopes, exclusions or matching rules, use Target JSON instead.")]
    public List<string>? TargetKeywords { get; set; }

    [Display("Date from", Description = "start date of the time range required field minimal value: 2025-08-01 date format: \"yyyy-mm-dd\"")]
    [JsonProperty("date_from")]
    public DateTime DateFrom { get; set; }

    [Display("Date to", Description = "end date of the time range required field Note: the value specified in date_from cannot exceed the value in date_to date format: \"yyyy-mm-dd\"")]
    [JsonProperty("date_to")]
    public DateTime DateTo { get; set; }

    [Display("Group range", Description = "timeseries delta range required field possible values: day , week , month , year")]
    [JsonProperty("group_range")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.GroupRangeOptions17))]
    public string GroupRange { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTimeseriesDeltaLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AiVisibilityLlmMentionsTimeseriesDeltaLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Platform", Description = "target platform optional field possible values: chat_gpt , google default value: google Note: if the platform is not specified, the data is returned for both platforms Note #2: chat_gpt data is available for the United States and English only")]
    [JsonProperty("platform")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.PlatformOptions18))]
    public string? Platform { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
