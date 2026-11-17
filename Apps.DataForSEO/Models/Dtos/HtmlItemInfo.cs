using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class HtmlItemInfo
{
    [Display("Page")]
    [JsonProperty("page")]
    public long? Page { get; set; }

    [Display("Date")]
    [JsonProperty("date")]
    public DateTime? Date { get; set; }

    [Display("HTML")]
    [JsonProperty("html")]
    public string? Html { get; set; }
}
