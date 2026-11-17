using Blackbird.Applications.Sdk.Common;

namespace Apps.DataForSEO.Models.Responses;

public class ReadyTaskResponse
{
    [Display("Task ID")]
    public string TaskId { get; set; } = string.Empty;

    [Display("Task family")]
    public string Family { get; set; } = string.Empty;

    [Display("Task tag")]
    public string? Tag { get; set; }
}
