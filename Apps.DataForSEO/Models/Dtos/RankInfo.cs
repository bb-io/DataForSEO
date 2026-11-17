using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class RankInfo
{
    [Display("Page rank")]
    [JsonProperty("page_rank")]
    public long? PageRank { get; set; }

    [Display("Main domain rank")]
    [JsonProperty("main_domain_rank")]
    public long? MainDomainRank { get; set; }
}
