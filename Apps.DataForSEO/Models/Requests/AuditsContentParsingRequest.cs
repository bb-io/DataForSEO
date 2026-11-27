using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class AuditsContentParsingRequest
{
    [Display("URL", Description = "URL of the content to parse required field URL of the page to parse example: `https://dataforseo.com/blog/a-versatile-alternative-to-google-trends-exploring-the-power-of-dataforseo-trends-api`")]
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.AuditsContentParsingIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Markdown view", Description = "return page content as markdown optional field if set to true , the markdown-formatted content of the page will be returned in the page_as_markdown field of the response; default value: false")]
    [JsonProperty("markdown_view")]
    public bool? MarkdownView { get; set; }
}
