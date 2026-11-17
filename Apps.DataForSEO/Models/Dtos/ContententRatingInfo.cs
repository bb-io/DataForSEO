using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class ContententRatingInfo
{
    [Display("Name")]
    [JsonProperty("name")]
    public string? Name { get; set; }

    [Display("Rating value")]
    [JsonProperty("rating_value")]
    public double? RatingValue { get; set; }

    [Display("Rating count")]
    [JsonProperty("rating_count")]
    public long? RatingCount { get; set; }

    [Display("Max rating value")]
    [JsonProperty("max_rating_value")]
    public double? MaxRatingValue { get; set; }

    [Display("Relative rating")]
    [JsonProperty("relative_rating")]
    public double? RelativeRating { get; set; }
}
