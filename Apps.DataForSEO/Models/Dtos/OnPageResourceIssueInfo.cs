using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageResourceIssueInfo
{
    [Display("Errors")]
    [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageResourceIssueItemInfo> Errors { get; set; } = [];

    [Display("Warnings")]
    [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageResourceIssueItemInfo> Warnings { get; set; } = [];
}
