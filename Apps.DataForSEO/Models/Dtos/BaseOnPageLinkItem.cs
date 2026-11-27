using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BaseOnPageLinkItem
{
    [Display("Type")]
    [JsonProperty("type")]
    public string? Type { get; set; }

    [Display("Domain from")]
    [JsonProperty("domain_from")]
    public string? DomainFrom { get; set; }

    [Display("Domain to")]
    [JsonProperty("domain_to")]
    public string? DomainTo { get; set; }

    [Display("Page from")]
    [JsonProperty("page_from")]
    public string? PageFrom { get; set; }

    [Display("Page to")]
    [JsonProperty("page_to")]
    public string? PageTo { get; set; }

    [Display("Link from")]
    [JsonProperty("link_from")]
    public string? LinkFrom { get; set; }

    [Display("Link to")]
    [JsonProperty("link_to")]
    public string? LinkTo { get; set; }

    [Display("Dofollow")]
    [JsonProperty("dofollow")]
    public bool? Dofollow { get; set; }

    [Display("Page from scheme")]
    [JsonProperty("page_from_scheme")]
    public string? PageFromScheme { get; set; }

    [Display("Page to scheme")]
    [JsonProperty("page_to_scheme")]
    public string? PageToScheme { get; set; }

    [Display("Direction")]
    [JsonProperty("direction")]
    public string? Direction { get; set; }

    [Display("Is broken")]
    [JsonProperty("is_broken")]
    public bool? IsBroken { get; set; }

    [Display("Is link relation conflict")]
    [JsonProperty("is_link_relation_conflict")]
    public bool? IsLinkRelationConflict { get; set; }

    [Display("Page to status code")]
    [JsonProperty("page_to_status_code")]
    public long? PageToStatusCode { get; set; }

    [Display("Link attribute")]
    [JsonProperty("link_attribute", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> LinkAttribute { get; set; } = [];

    [Display("Text")]
    [JsonProperty("text")]
    public string? Text { get; set; }

    [Display("Image alt")]
    [JsonProperty("image_alt")]
    public string? ImageAlt { get; set; }

    [Display("Image src")]
    [JsonProperty("image_src")]
    public string? ImageSrc { get; set; }

    [Display("Is valid hreflang")]
    [JsonProperty("is_valid_hreflang")]
    public bool? IsValidHreflang { get; set; }

    [Display("Hreflang")]
    [JsonProperty("hreflang")]
    public string? Hreflang { get; set; }
}
