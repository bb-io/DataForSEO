using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class AmazonDeliveryInfo
{
    [Display("Delivery message")]
    [JsonProperty("delivery_message")]
    public string? DeliveryMessage { get; set; }

    [Display("Delivery date from")]
    [JsonProperty("delivery_date_from")]
    public string? DeliveryDateFrom { get; set; }

    [Display("Delivery date to")]
    [JsonProperty("delivery_date_to")]
    public string? DeliveryDateTo { get; set; }

    [Display("Fastest delivery date from")]
    [JsonProperty("fastest_delivery_date_from")]
    public string? FastestDeliveryDateFrom { get; set; }

    [Display("Fastest delivery date to")]
    [JsonProperty("fastest_delivery_date_to")]
    public string? FastestDeliveryDateTo { get; set; }

    [Display("Delivery price")]
    [JsonProperty("delivery_price")]
    public PriceInfo? DeliveryPrice { get; set; }
}
