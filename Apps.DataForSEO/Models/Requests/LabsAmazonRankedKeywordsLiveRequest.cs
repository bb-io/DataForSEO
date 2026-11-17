using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsAmazonRankedKeywordsLiveRequest
{
    [Display("Asin", Description = "product ID required field unique product identifier (ASIN) on Amazon; you can receive the asin parameter by making a separate request to the Amazon Products endpoint")]
    [JsonProperty("asin")]
    public string Asin { get; set; } = string.Empty;

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsAmazonRankedKeywordsLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsAmazonRankedKeywordsLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to true only core keywords will be returned, all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Filters JSON", Description = "Advanced structured query. Supply a JSON array. See the input audit and provider field documentation. array of results filtering parameters optional field you can add several filters at once (8 filters maximum) you should set a logical operator and , or between the conditions the f")]
    [JsonProperty("filters")]
    public string? FiltersJson { get; set; }

    [Display("Order by", Description = "results sorting rules optional field you can use the same values as in the filters array to sort the results possible sorting types: asc - results will be sorted in the ascending order desc - results will be sorted in the descending order you should use a comma to set up a sorting parameter example: [\"keyword_data.keyword_info.competition")]
    [JsonProperty("order_by")]
    public List<string>? OrderBy { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Maximum results", Description = "Maximum total results across pages. Default 100. Additional pages may incur additional charges.")]
    public int? MaximumResults { get; set; }
}
