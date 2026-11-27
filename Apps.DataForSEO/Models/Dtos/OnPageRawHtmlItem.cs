using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageRawHtmlItem
{
    [Display("HTML")]
    [JsonProperty("html")]
    public string? Html { get; set; }
}
