using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsContentParsingLiveRequest
{
    [Display("URL", Description = "URL of the content to parse required field URL of the page to parse example: `https://www.fujielectric.com/`")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("Custom user agent", Description = "custom user agent optional field custom user agent for crawling a website example: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36 default value: Mozilla/5.0 (compatible; RSiteAuditor)")]
    [JsonProperty("custom_user_agent")]
    public string? CustomUserAgent { get; set; }

    [Display("Browser preset", Description = "preset for browser screen parameters optional field if you use this field, you don't need to indicate browser_screen_width , browser_screen_height , browser_screen_scale_factor possible values: desktop , mobile , tablet desktop preset will apply the following values: browser_screen_width: 1920 browser_screen_height: 1080 browser_screen_sc")]
    [JsonProperty("browser_preset")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BrowserPresetOptions1))]
    public string? BrowserPreset { get; set; }

    [Display("Browser screen width", Description = "browser screen width optional field you can set a custom browser screen width to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; Note: to use this parameter, set enable_javascript or enable_browser_rendering to true minimum value, in pixels: 240 maximum value, ")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "browser screen height optional field you can set a custom browser screen height to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; Note: to use this parameter, set enable_javascript or enable_browser_rendering to true minimum value, in pixels: 240 maximum value")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser screen scale factor optional field you can set a custom browser screen resolution ratio to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; Note: to use this parameter, set enable_javascript or enable_browser_rendering to true minimum value: 0.5 maximum ")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Store raw HTML", Description = "store HTML of a crawled page optional field set to true if you want to get the HTML of the page using the OnPage Raw HTML endpoint default value: false")]
    [JsonProperty("store_raw_html")]
    public bool? StoreRawHtml { get; set; }

    [Display("Disable cookie popup", Description = "disable the cookie popup optional field set to true if you want to disable the popup requesting cookie consent from the user; default value: false")]
    [JsonProperty("disable_cookie_popup")]
    public bool? DisableCookiePopup { get; set; }

    [Display("Accept language", Description = "language header for accessing the website optional field all locale formats are supported (xx, xx-XX, xxx-XX, etc.) Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the \"type\":\"broken in the response array")]
    [JsonProperty("accept_language")]
    public string? AcceptLanguage { get; set; }

    [Display("Enable javascript", Description = "load javascript on a page optional field set to true if you want to load the scripts available on a page default value: false Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article ; the cost can be calculated on the Pricing Page")]
    [JsonProperty("enable_javascript")]
    public bool? EnableJavascript { get; set; }

    [Display("Enable browser rendering", Description = "emulate browser rendering to measure Core Web Vitals optional field by using this parameter you will be able to emulate a browser when loading a web page; enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page; default value: false set to true to obtain Core Web Vitals (FID, CLS, LCP) metri")]
    [JsonProperty("enable_browser_rendering")]
    public bool? EnableBrowserRendering { get; set; }

    [Display("Enable xhr", Description = "enable XMLHttpRequest on a page optional field set to true if you want our crawler to request data from a web server using the XMLHttpRequest object default value: false if you use this field, enable_javascript must be set to true ;")]
    [JsonProperty("enable_xhr")]
    public bool? EnableXhr { get; set; }

    [Display("Switch pool", Description = "switch proxy pool optional field if true , additional proxy pools will be used to obtain the requested data; the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors")]
    [JsonProperty("switch_pool")]
    public bool? SwitchPool { get; set; }

    [Display("Ip pool for scan", Description = "proxy pool optional field you can choose a location of the proxy pool that will be used to obtain the requested data; the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errors possible values: us , de")]
    [JsonProperty("ip_pool_for_scan")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.IpPoolForScanOptions21))]
    public string? IpPoolForScan { get; set; }

    [Display("Markdown view", Description = "return page content as markdown optional field if set to true , the markdown-formatted content of the page will be returned in the page_as_markdown field of the response; default value: false")]
    [JsonProperty("markdown_view")]
    public bool? MarkdownView { get; set; }
}
