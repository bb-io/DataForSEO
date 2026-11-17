using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContentCommentInfo
{
    [Display("Rating")]
    [JsonProperty("rating")]
    public ContententRatingInfo? Rating { get; set; }

    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Publish date")]
    [JsonProperty("publish_date")]
    public string? PublishDate { get; set; }

    [Display("Author")]
    [JsonProperty("author")]
    public string? Author { get; set; }

    [Display("Have form")]
    [JsonProperty("have_form")]
    public bool? HaveForm { get; set; }

    [Display("Primary content")]
    [JsonProperty("primary_content", NullValueHandling = NullValueHandling.Ignore)]
    public List<SectionContentItemInfo> PrimaryContent { get; set; } = [];
}
