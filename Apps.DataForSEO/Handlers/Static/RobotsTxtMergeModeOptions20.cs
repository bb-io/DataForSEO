using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class RobotsTxtMergeModeOptions20 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("merge", "Merge"),
        new("override", "Override")
    ];
}
