using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class BacklinksPageMeta
{
    [Display("Title")]
    [JsonProperty("title")]
    public string? Title { get; set; }

    [Display("Canonical")]
    [JsonProperty("canonical")]
    public string? Canonical { get; set; }

    [Display("Internal links count")]
    [JsonProperty("internal_links_count")]
    public long? InternalLinksCount { get; set; }

    [Display("External links count")]
    [JsonProperty("external_links_count")]
    public long? ExternalLinksCount { get; set; }

    [Display("Images count")]
    [JsonProperty("images_count")]
    public long? ImagesCount { get; set; }

    [Display("Words count")]
    [JsonProperty("words_count")]
    public long? WordsCount { get; set; }

    [Display("Page spam score")]
    [JsonProperty("page_spam_score")]
    public long? PageSpamScore { get; set; }

    [Display("Social media tags")]
    [JsonProperty("social_media_tags")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? SocialMediaTags { get; set; }

    [Display("H1")]
    [JsonProperty("h1", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> H1 { get; set; } = [];

    [Display("H2")]
    [JsonProperty("h2", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> H2 { get; set; } = [];

    [Display("H3")]
    [JsonProperty("h3", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> H3 { get; set; } = [];

    [Display("Images alt")]
    [JsonProperty("images_alt", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ImagesAlt { get; set; } = [];

    [Display("Powered by")]
    [JsonProperty("powered_by", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> PoweredBy { get; set; } = [];

    [Display("Language")]
    [JsonProperty("language")]
    public string? Language { get; set; }

    [Display("Charset")]
    [JsonProperty("charset")]
    public string? Charset { get; set; }

    [Display("Platform type")]
    [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> PlatformType { get; set; } = [];

    [Display("Technologies")]
    [JsonProperty("technologies")]
    [JsonConverter(typeof(Apps.DataForSEO.Utils.JsonTextConverter))]
    public string? Technologies { get; set; }
}
