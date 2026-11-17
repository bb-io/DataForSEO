using Apps.DataForSEO.Constants;
using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class TaskFamilyHandler : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() => TaskFamilies.Values.Select(x => new DataSourceItem(x.Key, x.Value.Name));
}
