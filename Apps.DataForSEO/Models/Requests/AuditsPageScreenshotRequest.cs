using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsPageScreenshotRequest
{
    [Display("URL", Description = "page url required field absolute URL of the page to snap note: if the URL you indicate here returns a 404 status code or the indicated value is not a valid URL, you will obtain \"error_message\":\"Screenshot is empty\" in the response array")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("Accept language", Description = "language header for accessing the website optional field all locale formats are supported (xx, xx-XX, xxx-XX, etc.) note: if you do not specify this parameter, some websites may deny access; in this case, you will obtain \"error_message\":\"Screenshot is empty\" in the response array")]
    [JsonProperty("accept_language")]
    public string? AcceptLanguage { get; set; }

    [Display("Custom user agent", Description = "custom user agent optional field custom user agent for crawling a website example: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36 default value: Mozilla/5.0 (compatible; RSiteAuditor)")]
    [JsonProperty("custom_user_agent")]
    public string? CustomUserAgent { get; set; }

    [Display("Browser preset", Description = "preset for browser screen parameters optional field if you use this field, you don't need to indicate browser_screen_width , browser_screen_height , browser_screen_scale_factor possible values: desktop , mobile , tablet desktop preset will apply the following values: browser_screen_width: 1920 browser_screen_height: 1080 browser_screen_sc")]
    [JsonProperty("browser_preset")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BrowserPresetOptions1))]
    public string? BrowserPreset { get; set; }

    [Display("Browser screen width", Description = "browser screen width optional field you can set a custom browser screen width to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; minimum value, in pixels: 240 maximum value, in pixels: 9999")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen height optional field you can set a custom browser screen height to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; minimum value, in pixels: 240 maximum value, in pixels: 9999")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser screen scale factor optional field you can set a custom browser screen resolution ratio to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; minimum value: 0.5 maximum value: 3")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Full page screenshot", Description = "take a screenshot of the full page optional field set to false if you want to capture only the part of the page displayed before scrolling default value: true")]
    [JsonProperty("full_page_screenshot")]
    public bool? FullPageScreenshot { get; set; }

    [Display("Disable cookie popup", Description = "disable the cookie popup optional field set to true if you want to disable the popup requesting cookie consent from the user; default value: false")]
    [JsonProperty("disable_cookie_popup")]
    public bool? DisableCookiePopup { get; set; }

    [Display("Switch pool", Description = "switch proxy pool optional field if true , additional proxy pools will be used to obtain the requested data; the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors")]
    [JsonProperty("switch_pool")]
    public bool? SwitchPool { get; set; }

    [Display("Ip pool for scan", Description = "proxy pool optional field you can choose a location of the proxy pool that will be used to obtain the requested data; the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errors possible values: us , de")]
    [JsonProperty("ip_pool_for_scan")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.IpPoolForScanOptions21))]
    public string? IpPoolForScan { get; set; }
}
