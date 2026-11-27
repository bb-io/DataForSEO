using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RankChanges
{
    [Display("Previous rank absolute")]
    [JsonProperty("previous_rank_absolute")]
    public long? PreviousRankAbsolute { get; set; }

    [Display("Is new")]
    [JsonProperty("is_new")]
    public bool? IsNew { get; set; }

    [Display("Is up")]
    [JsonProperty("is_up")]
    public bool? IsUp { get; set; }

    [Display("Is down")]
    [JsonProperty("is_down")]
    public bool? IsDown { get; set; }
}
