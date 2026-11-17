using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class DynamicResult
{
    [Display("Details", Description = "See the complete JSON report file for this result.")]
    public string Details { get; set; } = "Full result is available in Report file.";
}
