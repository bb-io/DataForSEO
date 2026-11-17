using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsLighthouseLiveJsonRequest
{
    [Display("URL", Description = "target URL required field target page should be specified with its absolute URL (including http:// or https://) example: https://dataforseo.com/")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("For mobile", Description = "applies mobile emulation optional field if set to true , Lighthouse will use mobile device and screen emulation to test the page against mobile environment if set to false , the results will be provided for desktop default value: false")]
    [JsonProperty("for_mobile")]
    public bool? ForMobile { get; set; }

    [Display("Categories", Description = "categories of Lighthouse audits optional field each category is a collection of audits and audit groups that applies weighting and scoring to the section ( see official definition ) if you ignore this field, we will return data for all categories unless you specify audits use this field to get data for specific categories you indicate her")]
    [JsonProperty("categories")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.CategoriesOptions22))]
    public List<string>? Categories { get; set; }

    [Display("Audits", Description = "Lighthouse audits optional field audits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score ( see official definition ); if you ignore this field, we will return data for all audits ; use this field to get data for specific audits you indicate here; Note: that some audits do not be")]
    [JsonProperty("audits")]
    public List<string>? Audits { get; set; }

    [Display("Version", Description = "lighthouse version optional field you can obtain the results specific to a certain Lighthouse version by specifying its number the list of available versions is available through the Lighthouse Versions endpoint")]
    [JsonProperty("version")]
    public string? Version { get; set; }

    [Display("Language code", Description = "Choose an explicit search market. Suggestions are scoped to this product; mapped provider codes remain supported.")]
    [JsonProperty("language_code")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsLighthouseLiveJsonLanguageCodeHandler))]
    public string LanguageCode { get; set; } = string.Empty;

    [Display("Custom user agent", Description = "custom user agent optional field specify the custom user agent used by the browser when running the Lighthouse audit; can be specified with up to 254 characters;")]
    [JsonProperty("custom_user_agent")]
    public string? CustomUserAgent { get; set; }

    [Display("Browser screen width", Description = "browser screen width optional field set the screen width of the browser used for the Lighthouse audit to emulate a specific device; can be specified within the following range: 240\u20139999 ;")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen height optional field set the screen height of the browser used for the Lighthouse audit to emulate a specific device; can be specified within the following range: 240\u20139999 ;")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser screen scale factor optional field set the device pixel ratio of the browser used for the Lighthouse audit; can be specified within the following range: 0.5\u20133 ;")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Browser network throttling method", Description = "browser network throttling method optional field defines the method used to apply throttling during the Lighthouse audit; possible vaules: simulate - calculates estimated performance metrics without applying explicit throttling; devtools - applies the throttling settings specified in browser_network_throttling and browser_cpu_throttling_m")]
    [JsonProperty("browser_network_throttling_method")]
    public string? BrowserNetworkThrottlingMethod { get; set; }

    [Display("Browser cpu throttling multiplier", Description = "browser CPU throttling multiplier required if browser_network_throttling_method is set to devtools ; set the CPU throttling multiplier to simulate device performance conditions during the Lighthouse audit; can be specified within the following range: 1\u20134 ; Note: this parameter is applied only when browser_network_throttling_method is set ")]
    [JsonProperty("browser_cpu_throttling_multiplier")]
    public double? BrowserCpuThrottlingMultiplier { get; set; }

    [Display("Browser network throttling", Description = "browser network throttling required if browser_network_throttling_method is set to devtools ; set the network throttling profile to simulate connection speed conditions during the Lighthouse audit; possible values: no_throttling , fast_4g , slow_4g , regular_3g , pc ; Note: this parameter is applied only when browser_network_throttling_me")]
    [JsonProperty("browser_network_throttling")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BrowserNetworkThrottlingOptions23))]
    public string? BrowserNetworkThrottling { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}
