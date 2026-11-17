using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class OsOptions5 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("windows", "Windows"),
        new("macos", "Macos"),
        new("android", "Android"),
        new("ios", "Ios")
    ];
}
