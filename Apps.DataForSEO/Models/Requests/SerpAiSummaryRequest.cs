using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Requests;

public class SerpAiSummaryRequest
{
    [Display("Task ID", Description = "Map the task ID from submission. Suggestions contain uncollected completed tasks only; collected or pending tasks may be absent.")]
    [JsonProperty("task_id")]
    [Blackbird.Applications.Sdk.Common.Dynamic.DataSource(typeof(Apps.DataForSEO.Handlers.SerpAiSummaryTaskIdHandler))]
    public string TaskId { get; set; } = string.Empty;

    [Display("Prompt", Description = "AI prompt optional field additional task for AI summariser; any form of text, question or information that communicates to AI what response you're looking for; max number of symbols or characters you can specify: 2000 ; note: your prompt has to be relevant to the keyword specified in the POST request to SERP API")]
    [JsonProperty("prompt")]
    public string? Prompt { get; set; }

    [Display("Support extra", Description = "support extra SERP features optional field if set to true , the AI model will consider the following extra SERP features, in addition to organic results: answer_box , knowledge_graph , featured_snippet ; default value: true")]
    [JsonProperty("support_extra")]
    public bool? SupportExtra { get; set; }

    [Display("Fetch content", Description = "fetch content from pages in SERPs optional field if set to true , the API will fetch the content from pages featured in SERP results, and the AI model will consider this content when generating the summary in the result; default value: false")]
    [JsonProperty("fetch_content")]
    public bool? FetchContent { get; set; }

    [Display("Include links", Description = "include source links in the summary optional field if set to true , the summary field in the API response will contain links to sources of the generated summary; default value: false")]
    [JsonProperty("include_links")]
    public bool? IncludeLinks { get; set; }
}
