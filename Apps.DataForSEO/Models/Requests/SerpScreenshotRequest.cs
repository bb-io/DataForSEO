using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpScreenshotRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("task_id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpScreenshotTaskIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Browser preset", Description = "browser resolution preset optional field browser preset associated with a certain device type can take the following values: desktop , tablet , mobile Note: by default, browser preset corresponds to the device type specified in the POST request")]
    [JsonProperty("browser_preset")]
    [Blackbird.Applications.Sdk.Common.Dictionaries.StaticDataSource(typeof(Apps.DataForSEO.Handlers.Static.BrowserPresetOptions1))]
    public string? BrowserPreset { get; set; }

    [Display("Browser screen width", Description = "width of the browser resolution optional field can be specified in the following range: 240-9999 default value for desktop : 1920 default value for mobile : 390 default value for table : 1024")]
    [JsonProperty("browser_screen_width")]
    public long? BrowserScreenWidth { get; set; }

    [Display("Browser screen height", Description = "height of the browser resolution optional field can be specified in the following range: 240-9999 default value for desktop : 1080 default value for mobile : 844 default value for table : 1366")]
    [JsonProperty("browser_screen_height")]
    public long? BrowserScreenHeight { get; set; }

    [Display("Browser screen scale factor", Description = "browser scale factor optional field can be specified in the following range: 0.5-3 default value for desktop : 1 default value for mobile : 3 default value for table : 2")]
    [JsonProperty("browser_screen_scale_factor")]
    public double? BrowserScreenScaleFactor { get; set; }

    [Display("Page", Description = "number of SERP pages optional field if depth in the corresponding Task POST request exceeds 10 results (or 1 SERP page), specify the number of SERP pages to screenshot; default value: 1")]
    [JsonProperty("page")]
    public long? Page { get; set; }
}
