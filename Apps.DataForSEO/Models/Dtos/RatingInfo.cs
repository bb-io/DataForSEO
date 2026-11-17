using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RatingInfo
{
    [Display("Rating type")]
    [JsonProperty("rating_type")]
    public string? RatingType { get; set; }

    [Display("Value")]
    [JsonProperty("value")]
    public double? Value { get; set; }

    [Display("Votes count")]
    [JsonProperty("votes_count")]
    public long? VotesCount { get; set; }

    [Display("Rating max")]
    [JsonProperty("rating_max")]
    public long? RatingMax { get; set; }
}
