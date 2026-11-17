using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsTaskPostRequest
{
    [Display("Target", Description = "target domain required field domain name should be specified without https:// and www. if you specify the page URL, the results will be returned for the domain included in the URL")]
    [JsonProperty("target")]
    public string Target { get; set; } = string.Empty;

    [Display("Max crawl pages", Description = "crawled pages limit required field the number of pages to crawl on the specified domain Note: if you set max_crawl_pages to 1 and do not specify start_url or set a homepage in it, the following sitewide checks will be disabled: test_canonicalization , enable_www_redirect_check , test_hidden_server_signature , test_page_not_found , test_di")]
    [JsonProperty("max_crawl_pages")]
    public long MaxCrawlPages { get; set; }

    [Display("Start URL", Description = "the first url to crawl optional field Note: you should specify an absolute URL if you want to crawl a single page, specify its URL in this field and additionally set the max_crawl_pages parameter to 1 you can also use the live Instant Pages endpoint to get page-specific data")]
    [JsonProperty("start_url")]
    public string? StartUrl { get; set; }

    [Display("Force sitewide checks", Description = "enable sitewide checks when crawling a single page optional field set to true to get data on sitewide checks when crawling a single page; default value: false")]
    [JsonProperty("force_sitewide_checks")]
    public bool? ForceSitewideChecks { get; set; }

    [Display("Priority URLS", Description = "urls to be crawled bypassing the queue optional field URLs specified in this array will be crawled in the first instance, bypassing the crawling queue; Note: you should specify the absolute URL; you can specify up to 20 URLs ; all URLs in the array must belong to the target domain; subdomains will be ignored unless the allow_subdomains pa")]
    [JsonProperty("priority_urls")]
    public List<string>? PriorityUrls { get; set; }

    [Display("Max crawl depth", Description = "crawl depth optional field the linking depth of the pages to crawl; for example, starting page of the crawl is level 0, pages that have links from that page are level 1, etc.")]
    [JsonProperty("max_crawl_depth")]
    public long? MaxCrawlDepth { get; set; }

    [Display("Crawl delay", Description = "delay between hits, ms optional field the custom delay between crawler hits to the server default value: 2000")]
    [JsonProperty("crawl_delay")]
    public long? CrawlDelay { get; set; }

    [Display("Store raw HTML", Description = "store HTML of crawled pages optional field set to true if you want to get the HTML of the page using the OnPage Raw HTML endpoint default value: false")]
    [JsonProperty("store_raw_html")]
    public bool? StoreRawHtml { get; set; }

    [Display("Enable content parsing", Description = "parse content on crawled pages optional field set to true to use the OnPage Content Parsing endpoint default value: false Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article ; the cost can be calculated on the Pricing Page")]
    [JsonProperty("enable_content_parsing")]
    public bool? EnableContentParsing { get; set; }

    [Display("Support cookies", Description = "support cookies on crawled pages optional field set to true to support cookies when crawling the pages default value: false")]
    [JsonProperty("support_cookies")]
    public bool? SupportCookies { get; set; }

    [Display("Accept language", Description = "language header for accessing the website optional field all locale formats are supported (xx, xx-XX, xxx-XX, etc.) Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the \"type\":\"broken in the response array")]
    [JsonProperty("accept_language")]
    public string? AcceptLanguage { get; set; }

    [Display("Custom robots txt", Description = "custom robots.txt settings optional field example: Disallow: /directory1/")]
    [JsonProperty("custom_robots_txt")]
    public string? CustomRobotsTxt { get; set; }

    [Display("Robots txt merge mode", Description = "merge with or override robots.txt settings optional field possible values: merge , override ; set to override if you want to ignore website crawling restrictions and other robots.txt settings default value: merge ; Note: if set to override , specify the custom_robots_txt parameter")]
    [JsonProperty("robots_txt_merge_mode")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.RobotsTxtMergeModeOptions20))]
    public string? RobotsTxtMergeMode { get; set; }

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

    [Display("Browser screen height", Description = "browser screen height optional field you can set a custom browser screen height to perform an audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; Note: to use this parameter, set enable_javascript or enable_browser_rendering to true minimum value, in pixels: 240 maximum va")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser screen scale factor optional field you can set a custom browser screen resolution ratio to perform audit for a particular device; if you use this field, you don't need to indicate browser_preset as it will be ignored; Note: to use this parameter, set enable_javascript or enable_browser_rendering to true minimum value: 0.5 maximum ")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Respect sitemap", Description = "respect sitemap when crawling optional field set to true if you want to follow the order of pages indicated in the primary sitemap when crawling; default value: false Note: if set to true , the click_depth value in the API response will equal 0 ; the max_crawl_depth field of the request will be ignored, you can specify the number of pages")]
    [JsonProperty("respect_sitemap")]
    public bool? RespectSitemap { get; set; }

    [Display("Custom sitemap", Description = "custom sitemap url optional field the URL of the page where the alternative sitemap is located Note: if you want to use this parameter, respect_sitemap should be true")]
    [JsonProperty("custom_sitemap")]
    public string? CustomSitemap { get; set; }

    [Display("Crawl sitemap only", Description = "crawl only pages indicated in the sitemap optional field set to true if you want to crawl only the pages indicated in the sitemap if you set this parameter to true and do not specify custom_sitemap , we will crawl the default sitemap default value: false Note: if you want to use this parameter, respect_sitemap should be true")]
    [JsonProperty("crawl_sitemap_only")]
    public bool? CrawlSitemapOnly { get; set; }

    [Display("Load resources", Description = "load resources optional field set to true if you want to load image, stylesheets, scripts, and broken resources default value: false Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article ; the cost can be calculated on the Pricing Page")]
    [JsonProperty("load_resources")]
    public bool? LoadResources { get; set; }

    [Display("Enable www redirect check", Description = "check if the domain implemented the www redirection optional field set to true if you want to check if the requested domain implemented the www to non-www or non-www to www redirect; default value: false")]
    [JsonProperty("enable_www_redirect_check")]
    public bool? EnableWwwRedirectCheck { get; set; }

    [Display("Enable javascript", Description = "load javascript on a page optional field set to true if you want to load the scripts available on a page default value: false Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article ; the cost can be calculated on the Pricing Page")]
    [JsonProperty("enable_javascript")]
    public bool? EnableJavascript { get; set; }

    [Display("Enable xhr", Description = "enable XMLHttpRequest on a page optional field set to true if you want our crawler to request data from a web server using the XMLHttpRequest object default value: false ;if you use this field, enable_javascript must be set to true ;")]
    [JsonProperty("enable_xhr")]
    public bool? EnableXhr { get; set; }

    [Display("Enable browser rendering", Description = "emulate browser rendering to measure Core Web Vitals optional field by using this parameter you will be able to emulate a browser when loading a web page; enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page; default value: false set to true to obtain Core Web Vitals (FID, CLS, LCP) metri")]
    [JsonProperty("enable_browser_rendering")]
    public bool? EnableBrowserRendering { get; set; }

    [Display("Disable cookie popup", Description = "disable the cookie popup optional field set to true if you want to disable the popup requesting cookie consent from the user; default value: false")]
    [JsonProperty("disable_cookie_popup")]
    public bool? DisableCookiePopup { get; set; }

    [Display("Custom js", Description = "custom javascript optional field Note: that the execution time for the script you enter here should be 700 ms maximum, for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute: let meta = { haveGoogleAnalytics: false, haveTagManager: false };rnfor (var i = 0; i < document.scr")]
    [JsonProperty("custom_js")]
    public string? CustomJs { get; set; }

    [Display("Validate micromarkup", Description = "enable microdata validation optional field set to true if you want to use the OnPage API Microdata endpoint default value: false")]
    [JsonProperty("validate_micromarkup")]
    public bool? ValidateMicromarkup { get; set; }

    [Display("Allow subdomains", Description = "include pages on subdomains optional field set to true if you want to crawl all subdomains of a target website default value: false")]
    [JsonProperty("allow_subdomains")]
    public bool? AllowSubdomains { get; set; }

    [Display("Allowed subdomains", Description = "subdomains to crawl optional field specify subdomains that you want to crawl example: [\"blog.site.com\", \"my.site.com\", \"shop.site.com\"] Note: to use this parameter, the allow_subdomains parameter should be set to false ; otherwise, the content of allowed_subdomains field will be ignored and the results will be returned for all subdomains")]
    [JsonProperty("allowed_subdomains")]
    public List<string>? AllowedSubdomains { get; set; }

    [Display("Disallowed subdomains", Description = "subdomains not to crawl optional field specify subdomains that you don't want to crawl example: [\"status.site.com\", \"docs.site.com\"] Note: to use this parameter, the allow_subdomains parameter should be set to true")]
    [JsonProperty("disallowed_subdomains")]
    public List<string>? DisallowedSubdomains { get; set; }

    [Display("Check spell", Description = "check spelling optional field set to true to check spelling on a website using Hunspell library default value: false")]
    [JsonProperty("check_spell")]
    public bool? CheckSpell { get; set; }

    [Display("Check spell language", Description = "language of the spell check optional field supported languages: 'hy', 'eu', 'bg', 'ca', 'hr', 'cs', 'da', 'nl', 'en', 'eo', 'et', 'fo', 'fa', 'fr', 'fy', 'gl', 'ka', 'de', 'el', 'he', 'hu', 'is', 'ia', 'ga', 'it', 'rw', 'la', 'lv', 'lt', 'mk', 'mn', 'ne', 'nb', 'nn', 'pl', 'pt', 'ro', 'gd', 'sr', 'sk', 'sl', 'es', 'sv', 'tr', 'tk', 'uk', ")]
    [JsonProperty("check_spell_language")]
    public string? CheckSpellLanguage { get; set; }

    [Display("Check spell exceptions", Description = "words excluded from spell check optional field specify the words that you want to exclude from spell check maximum word length: 100 characters maximum amount of words: 1000 example: \"SERP\", \"minifiers\", \"JavaScript\"")]
    [JsonProperty("check_spell_exceptions")]
    public List<string>? CheckSpellExceptions { get; set; }

    [Display("Calculate keyword density", Description = "calculate keyword density for the target domain optional field set to true if you want to calculate keyword density for website pages default value: false Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article once the crawl is completed, you can obtain ke")]
    [JsonProperty("calculate_keyword_density")]
    public bool? CalculateKeywordDensity { get; set; }

    [Display("Checks threshold JSON", Description = "Advanced structured query. Supply a JSON object. See the input audit and provider field documentation. custom threshold values for checks optional field you can specify custom threshold values for the parameters included in the checks object of OnPage API responses; Note: only integ")]
    [JsonProperty("checks_threshold")]
    public string? ChecksThresholdJson { get; set; }

    [Display("Disable sitewide checks", Description = "prevent certain sitewide checks from running optional field specify the following checks to prevent them from running on the target website: \"test_page_not_found\" \"test_canonicalization\" \"test_https_redirect\" \"test_directory_browsing\" example: \"disable_sitewide_checks\": [\"test_directory_browsing\", \"test_page_not_found\"] learn more on our ")]
    [JsonProperty("disable_sitewide_checks")]
    public List<string>? DisableSitewideChecks { get; set; }

    [Display("Disable page checks", Description = "prevent certain page checks from running optional field specify certain checks to prevent them from running and impacting the onpage_score example: \"disable_page_checks\": [\"is_5xx_code\", \"is_4xx_code\"]")]
    [JsonProperty("disable_page_checks")]
    public List<string>? DisablePageChecks { get; set; }

    [Display("Switch pool", Description = "switch proxy pool optional field if true , additional proxy pools will be used to obtain the requested data; the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors")]
    [JsonProperty("switch_pool")]
    public bool? SwitchPool { get; set; }

    [Display("Return despite timeout", Description = "return data on pages despite the timeout error optional field if true , the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error; default value: false")]
    [JsonProperty("return_despite_timeout")]
    public bool? ReturnDespiteTimeout { get; set; }

    [Display("Tag", Description = "user-defined task identifier optional field the character limit is 255 you can use this parameter to identify the task and match it with the result you will find the specified tag value in the data object of the response")]
    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [Display("Pingback URL", Description = "notification URL of a completed task optional field when a task is completed we will notify you by GET request sent to the URL you have specified you can use the \u2018$id\u2019 string as a $id variable and \u2018$tag\u2019 as urlencoded $tag variable. We will set the necessary values before sending the request. example: http://your-server.com/pingscript?id=")]
    [JsonProperty("pingback_url")]
    public string? PingbackUrl { get; set; }
}
