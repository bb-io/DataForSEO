using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class PostbackDataOptions3 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("advanced", "Advanced"),
        new("html", "HTML"),
        new("regular", "Regular")
    ];
}
