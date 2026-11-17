using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsAmazonRelatedKeywordsLiveRequest
{
    [Display("Keyword", Description = "keyword required field UTF-8 encoding the keywords should be specified in the lowercase format learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsAmazonRelatedKeywordsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsAmazonRelatedKeywordsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "keyword search depth optional field default value: 1 ; number of the returned results depends on the value you set in this field; you can specify a level from 0 to 4; estimated number of keywords for each level (maximum): 0 - the keyword set in the keyword field 1 \u2013 6 keywords 2 \u2013 42 keywords 3 \u2013 258 keywords 4 \u2013 1554 keywords")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Include seed keyword", Description = "include data for the seed keyword optional field if set to true , data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response default value: false")]
    [JsonProperty("include_seed_keyword")]
    public bool? IncludeSeedKeyword { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to_ true only core keywords will be returned, all highly similar keywords will be excluded; default value: false n")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
