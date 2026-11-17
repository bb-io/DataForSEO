using Apps.DataForSEO.Handlers.Static;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dictionaries;

namespace Apps.DataForSEO.Models.Requests;

public class TaskEventRequest
{
    [Display("Task family", Description = "Default: Google organic SERP. Select the same family as the submission action.")]
    [StaticDataSource(typeof(TaskFamilyHandler))]
    public string? Family { get; set; }

    [Display("Task tag", Description = "Optional exact tag match. Leave empty to receive all matching tasks in this connection.")]
    public string? Tag { get; set; }
}
