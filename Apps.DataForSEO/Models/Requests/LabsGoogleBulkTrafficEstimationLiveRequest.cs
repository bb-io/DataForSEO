using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class LabsGoogleBulkTrafficEstimationLiveRequest
{
    [Display("Targets", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("targets")]
    public List<string>? Targets { get; set; }

    [Display("Targets file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? TargetsFile { get; set; }

    [Display("Location code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("location_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleBulkTrafficEstimationLiveLocationCodeHandler))]
    public string LocationCode { get; set; } = string.Empty;

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.LabsGoogleBulkTrafficEstimationLiveLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Item types", Description = "display results by item type optional field indicates the type of search results included in the response Note: if the item_types array contains item types that are different from organic , the results will be ordered by the first item type in the array possible values: [\"organic\", \"paid\", \"featured_snippet\", \"local_pack\"] default value: ")]
    [JsonProperty("item_types")]
    public List<string>? ItemTypes { get; set; }

    [Display("Ignore synonyms", Description = "ignore highly similar keywords optional field if set to_ true , only core keywords will be returned, all highly similar keywords will be excluded; default value: false")]
    [JsonProperty("ignore_synonyms")]
    public bool? IgnoreSynonyms { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
