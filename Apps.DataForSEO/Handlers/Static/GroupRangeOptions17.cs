using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class GroupRangeOptions17 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("day", "Day"),
        new("week", "Week"),
        new("month", "Month"),
        new("year", "Year")
    ];
}
