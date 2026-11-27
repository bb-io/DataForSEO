using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class BrowserNetworkThrottlingOptions23 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("no_throttling", "No throttling"),
        new("fast_4g", "Fast 4g"),
        new("slow_4g", "Slow 4g"),
        new("regular_3g", "Regular 3g"),
        new("pc", "Pc")
    ];
}
