using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class IndexHistory
{
    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("Total backlinks")]
    [JsonProperty("total_backlinks")]
    public long? TotalBacklinks { get; set; }

    [Display("Total pages")]
    [JsonProperty("total_pages")]
    public long? TotalPages { get; set; }
}
