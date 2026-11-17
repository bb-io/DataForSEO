using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.DataForSEO.Models.Responses;

public class ReportResponse<T>
{
    [Display("Results")]
    public List<T> Results { get; set; } = [];

    [Display("Tasks")]
    public List<TaskOutcome> Tasks { get; set; } = [];

    [Display("Total cost in USD", Description = "Sum of the charges reported for every request made by this action.")]
    public double Cost { get; set; }

    [Display("Content files", Description = "Extracted HTML and downloaded screenshots, where the action returns them.")]
    public List<FileReference> ContentFiles { get; set; } = [];

    [Display("Report file", Description = "Complete JSON responses, including fields not exposed individually in the editor.")]
    public FileReference File { get; set; } = new();
}
