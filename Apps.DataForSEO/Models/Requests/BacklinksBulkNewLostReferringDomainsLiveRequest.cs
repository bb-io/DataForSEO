using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class BacklinksBulkNewLostReferringDomainsLiveRequest
{
    [Display("Targets", Description = "Supply values here or a UTF-8 text file with one value per line; do not supply both.")]
    [JsonProperty("targets")]
    public List<string>? Targets { get; set; }

    [Display("Targets file", Description = "UTF-8 text, one value per line. Alternative to the collection input.")]
    public Blackbird.Applications.Sdk.Common.Files.FileReference? TargetsFile { get; set; }

    [Display("Date from", Description = "starting date of the time range optional field this field indicates the date which will be used as a threshold for new and lost referring domains; the referring domains that appeared in our index after the specified date will be considered as new; the referring domains that weren't found after the specified date, but were present before, ")]
    [JsonProperty("date_from")]
    public DateTime? DateFrom { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
