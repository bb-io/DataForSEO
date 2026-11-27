using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class CategoriesOptions22 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("seo", "SEO"),
        new("performance", "Performance"),
        new("best_practices", "Best practices"),
        new("accessibility", "Accessibility")
    ];
}
