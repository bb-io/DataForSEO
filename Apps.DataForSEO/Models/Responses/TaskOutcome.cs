using Blackbird.Applications.Sdk.Common;

namespace Apps.DataForSEO.Models.Responses;

public class TaskOutcome
{
    [Display("Task ID")]
    public string TaskId { get; set; } = string.Empty;

    [Display("Status code")]
    public int StatusCode { get; set; }

    [Display("Status message")]
    public string StatusMessage { get; set; } = string.Empty;

    [Display("Task cost in USD")]
    public double Cost { get; set; }

    [Display("Results ready")]
    public bool Ready { get; set; }
}
