using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DataForSEOLabsGoogleAvailableHistoryResultInfo
{
    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }
}
