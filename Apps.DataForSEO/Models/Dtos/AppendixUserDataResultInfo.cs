using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AppendixUserDataResultInfo
{
    [Display("Login")]
    [JsonProperty("login")]
    public string? Login { get; set; }

    [Display("Timezone")]
    [JsonProperty("timezone")]
    public string? Timezone { get; set; }

    [Display("Rates")]
    [JsonProperty("rates")]
    public AppendixRatesData? Rates { get; set; }

    [Display("Money")]
    [JsonProperty("money")]
    public AppendixMoneyData? Money { get; set; }

    [Display("Price")]
    [JsonProperty("price")]
    public AppendixPriceData? Price { get; set; }

    [Display("Backlinks subscription expiry date")]
    [JsonProperty("backlinks_subscription_expiry_date")]
    public string? BacklinksSubscriptionExpiryDate { get; set; }

    [Display("LLM mentions subscription expiry date")]
    [JsonProperty("llm_mentions_subscription_expiry_date")]
    public string? LlmMentionsSubscriptionExpiryDate { get; set; }
}
