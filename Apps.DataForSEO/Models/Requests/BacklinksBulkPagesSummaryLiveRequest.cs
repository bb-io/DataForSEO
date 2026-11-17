using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksBulkPagesSummaryLiveRequest
{
    [Display("Targets", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("targets")]
    public List<string>? Targets { get; set; }

    [Display("Targets file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? TargetsFile { get; set; }

    [Display("Include subdomains", Description = "indicates if the subdomains of the target will be included in the search optional field if set to false , the subdomains will be ignored default value: true")]
    [JsonProperty("include_subdomains")]
    public bool? IncludeSubdomains { get; set; }

    [Display("Rank scale", Description = "defines the scale used for calculating and displaying the rank , domain_from_rank , and page_from_rank values optional field you can use this parameter to choose whether rank values are presented on a 0\u2013100 or 0\u20131000 scale possible values: one_hundred \u2014 rank values are displayed on a 0\u2013100 scale one_thousand \u2014 rank values are displayed on")]
    [JsonProperty("rank_scale")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RankScaleOptions14))]
    public string? RankScale { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
