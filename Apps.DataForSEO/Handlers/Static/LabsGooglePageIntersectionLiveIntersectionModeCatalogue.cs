using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class LabsGooglePageIntersectionLiveIntersectionModeCatalogue : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("union", "Union"),
        new("intersect", "Intersect")
    ];
}
