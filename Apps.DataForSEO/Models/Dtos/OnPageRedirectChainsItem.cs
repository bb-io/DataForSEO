using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class OnPageRedirectChainsItem
{
    [Display("Is redirect loop")]
    [JsonProperty("is_redirect_loop")]
    public bool? IsRedirectLoop { get; set; }

    [Display("Chain")]
    [JsonProperty("chain", NullValueHandling = NullValueHandling.Ignore)]
    public List<OnPageRedirectLinkItem> Chain { get; set; } = [];
}
