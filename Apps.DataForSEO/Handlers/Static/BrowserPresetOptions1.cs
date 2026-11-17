using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class BrowserPresetOptions1 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("desktop", "Desktop"),
        new("mobile", "Mobile"),
        new("tablet", "Tablet")
    ];
}
