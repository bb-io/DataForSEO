using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleKeywordOverviewLiveRequest
{
    [Display("Keywords", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("keywords")]
    public List<string>? Keywords { get; set; }

    [Display("Keywords file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? KeywordsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleKeywordOverviewLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleKeywordOverviewLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Include SERP info", Description = "include data from SERP for each keyword optional field if set to true , we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response default value: false")]
    [JsonProperty("include_serp_info")]
    public bool? IncludeSerpInfo { get; set; }

    [Display("Include clickstream data", Description = "include or exclude data from clickstream-based metrics in the result optional field if the parameter is set to true , you will receive clickstream_keyword_info , keyword_info_normalized_with_clickstream , and keyword_info_normalized_with_bing fields in the response default value: false with this parameter enabled, you will be charged doub")]
    [JsonProperty("include_clickstream_data")]
    public bool? IncludeClickstreamData { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
