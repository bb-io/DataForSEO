using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class ContentContentAnalysisSummaryLivePageTypeCatalogue : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("ecommerce", "Ecommerce"),
        new("news", "News"),
        new("blogs", "Blogs"),
        new("message-boards", "Message-boards"),
        new("organization", "Organization")
    ];
}
