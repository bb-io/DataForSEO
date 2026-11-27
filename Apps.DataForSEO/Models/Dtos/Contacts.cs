using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class Contacts
{
    [Display("Telephones")]
    [JsonProperty("telephones", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Telephones { get; set; } = [];

    [Display("Emails")]
    [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Emails { get; set; } = [];
}
