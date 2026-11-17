using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class DeviceOptions2 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("desktop", "Desktop"),
        new("mobile", "Mobile")
    ];
}
