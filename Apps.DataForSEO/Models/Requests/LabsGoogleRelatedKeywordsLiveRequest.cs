using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleRelatedKeywordsLiveRequest
{
    [Display("Keyword", Description = "keyword required field UTF-8 encoding the keywords will be converted to lowercase format learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article")]
    [JsonProperty("keyword")]
    public string Keyword { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleRelatedKeywordsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleRelatedKeywordsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Depth", Description = "keyword search depth optional field default value: 1 number of the returned results depends on the value you set in this field you can specify a level from 0 to 4 estimated number of keywords for each level (maximum): 0 - the keyword set in the keyword field 1 \u2013 8 keywords 2 \u2013 72 keywords 3 \u2013 584 keywords 4 \u2013 4680 keywords")]
    [JsonProperty("depth")]
    public long? Depth { get; set; }

    [Display("Include seed keyword", Description = "include data for the seed keyword optional field if set to true , data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response default value: false")]
    [JsonProperty("include_seed_keyword")]
    public bool? IncludeSeedKeyword { get; set; }

    [Display("Include SERP info", Description = "include data from SERP for each keyword optional field if set to true , we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response default value: false")]
    [JsonProperty("include_serp_info")]
    public bool? IncludeSerpInfo { get; set; }

    [Display("Include clickstream data", Description = "")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Ignore synonyms", Description = "")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Replace with core keyword", Description = "return data for core keyword optional field if true , serp_info and related_keywords will be returned for the main keyword in the group that the specified keyword belongs to; if false , serp_info and related_keywords will be returned for the specified keyword (if available); refer to this help center article for more details; default valu")]
    [JsonProperty("replace_with_core_keyword")]
    public bool? ReplaceWithCoreKeyword { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting type example: [\"keyword_data.keyword_info.competition,desc")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
