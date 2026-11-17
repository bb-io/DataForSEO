using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class PageContentInfo
{
    [Display("Header")]
    [JsonProperty("header")]
    public PageSectionContentInfo? Header { get; set; }

    [Display("Footer")]
    [JsonProperty("footer")]
    public PageSectionContentInfo? Footer { get; set; }

    [Display("Main topic")]
    [JsonProperty("main_topic", NullValueHandling = NullValueHandling.Ignore)]
    public List<TopicInfo> MainTopic { get; set; } = [];

    [Display("Secondary topic")]
    [JsonProperty("secondary_topic", NullValueHandling = NullValueHandling.Ignore)]
    public List<TopicInfo> SecondaryTopic { get; set; } = [];

    [Display("Ratings")]
    [JsonProperty("ratings", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContententRatingInfo> Ratings { get; set; } = [];

    [Display("Offers")]
    [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContentOfferInfo> Offers { get; set; } = [];

    [Display("Comments")]
    [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
    public List<ContentCommentInfo> Comments { get; set; } = [];

    [Display("Contacts")]
    [JsonProperty("contacts")]
    public Contacts? Contacts { get; set; }
}
