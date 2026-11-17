using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsInstantPagesRequest
{
    [Display("URL", Description = "target page urlrequired fieldabsolute URL of the target page;Note #1: results will be returned for the specified URL only;Note #2: to prevent denial-of-service events, tasks that contain a duplicate crawl host will be returned with a 40501 error;to prevent this error from occurring, avoid setting tasks with the same domain if at least one")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("Custom user agent", Description = "custom user agentoptional fieldcustom user agent for crawling a websiteexample: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36default value: Mozilla/5.0 (compatible; RSiteAuditor)")]
    [JsonProperty("custom_user_agent")]
    public string? CustomUserAgent { get; set; }

    [Display("Browser preset", Description = "preset for browser screen parametersoptional fieldif you use this field, you don't need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factorpossible values:desktop, mobile, tabletdesktop preset will apply the following values:browser_screen_width: 1920browser_screen_height: 1080browser_screen_scale_factor: ")]
    [JsonProperty("browser_preset")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BrowserPresetOptions1))]
    public string? BrowserPreset { get; set; }

    [Display("Browser screen width", Description = "browser screen widthoptional fieldyou can set a custom browser screen width to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240maximum value, in pix")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen heightoptional fieldyou can set a custom browser screen height to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240maximum value, in p")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser screen scale factoroptional fieldyou can set a custom browser screen resolution ratio to perform audit for a particular device;if you use this field, you don't need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value: 0.5maximum value:")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Store raw HTML", Description = "store HTML of a crawled pageoptional fieldset to true if you want get the HTML of the page using the OnPage Raw HTML endpointdefault value: false")]
    [JsonProperty("store_raw_html")]
    public bool? StoreRawHtml { get; set; }

    [Display("Accept language", Description = "language header for accessing the websiteoptional fieldall locale formats are supported (xx, xx-XX, xxx-XX, etc.)Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the \"type\":\"broken in the response array")]
    [JsonProperty("accept_language")]
    public string? AcceptLanguage { get; set; }

    [Display("Load resources", Description = "load resourcesoptional fieldset to true if you want to load image, stylesheets, scripts, and broken resourcesdefault value: falseNote: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page")]
    [JsonProperty("load_resources")]
    public bool? LoadResources { get; set; }

    [Display("Enable browser rendering", Description = "emulate browser rendering to measure Core Web Vitalsoptional fieldby using this parameter you will be able to emulate a browser when loading a web page;enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page;default value: falseset to true to obtain Core Web Vitals (FID, CLS, LCP) metrics in")]
    [JsonProperty("enable_browser_rendering")]
    public bool? EnableBrowserRendering { get; set; }

    [Display("Disable cookie popup", Description = "disable the cookie popup optional fieldset to true if you want to disable the popup requesting cookie consent from the user;default value:false")]
    [JsonProperty("disable_cookie_popup")]
    public bool? DisableCookiePopup { get; set; }

    [Display("Return despite timeout", Description = "return data on pages despite the timeout erroroptional fieldif true, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;default value: false")]
    [JsonProperty("return_despite_timeout")]
    public bool? ReturnDespiteTimeout { get; set; }

    [Display("Enable javascript", Description = "load javascript on a pageoptional fieldset to true if you want to load the scripts available on a pagedefault value: falseNote: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page")]
    [JsonProperty("enable_javascript")]
    public bool? EnableJavascript { get; set; }

    [Display("Enable xhr", Description = "enable XMLHttpRequest on a pageoptional fieldset to true if you want our crawler to request data from a web server using the XMLHttpRequest objectdefault value:falseif you use this field, enable_javascript must be set to true;")]
    [JsonProperty("enable_xhr")]
    public bool? EnableXhr { get; set; }

    [Display("Custom js", Description = "custom javascriptoptional fieldNote that the execution time for the script you enter here should be 700 ms maximum;for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:let meta = { haveGoogleAnalytics: false, haveTagManager: false };rnfor (var i = 0; i = 0)rn meta.haveGoo")]
    [JsonProperty("custom_js")]
    public string? CustomJs { get; set; }

    [Display("Validate micromarkup", Description = "enable microdata validationoptional fieldif set to true, you can use the OnPage API Microdata endpoint with the id of the task;default value: false")]
    [JsonProperty("validate_micromarkup")]
    public bool? ValidateMicromarkup { get; set; }

    [Display("Check spell", Description = "check spellingoptional fieldset to true to check spelling on a website using Hunspell librarydefault value: false")]
    [JsonProperty("check_spell")]
    public bool? CheckSpell { get; set; }

    [Display("Checks threshold JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. custom threshold values for checksoptional fieldyou can specify custom threshold values for the parameters included in the checks array of OnPage API responses;Note: only integer t")]
    [JsonProperty("checks_threshold")]
    public string? ChecksThresholdJson { get; set; }

    [Display("Switch pool", Description = "switch proxy pooloptional fieldif true, additional proxy pools will be used to obtain the requested data;the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors")]
    [JsonProperty("switch_pool")]
    public bool? SwitchPool { get; set; }

    [Display("Ip pool for scan", Description = "proxy pooloptional fieldyou can choose a location of the proxy pool that will be used to obtain the requested data;the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errorspossible values: us, de")]
    [JsonProperty("ip_pool_for_scan")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.AuditsInstantPagesIpPoolForScanCatalogue))]
    public string? IpPoolForScan { get; set; }
}
