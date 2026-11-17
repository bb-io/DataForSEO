using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AiVisibilityChatGptLlmScraperLiveHtmlRequest
{
    [Display("Keyword", Description = "keyword required field you can specify up to 2000 characters in the keyword field all %## will be decoded (plus character \u2018+\u2019 will be decoded to a space character) if you need to use the \u201c%\u201d character for your keyword , please specify it as \u201c%25\u201d; if you need to use the \u201c+\u201d character for your keyword , please specify it as \u201c%2B\u201d learn mor")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Force web search", Description = "force AI agent to use web search optional field when enabled, the AI model is forced to access and cite current web information; default value: false ; Note: even if the parameter is set to true , there is no guarantee web sources will be cited in the response")]
    [JsonProperty("force_web_search")]
    public bool? ForceWebSearch { get; set; }

    [Display("Expand citations", Description = "return expanded citation bar in HTML results optional field to enable this parameter, force_web_search must also be enabled; when enabled, the endpoint will return HTML data from the expanded citation bar; default value: false")]
    [JsonProperty("expand_citations")]
    public bool? ExpandCitations { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
