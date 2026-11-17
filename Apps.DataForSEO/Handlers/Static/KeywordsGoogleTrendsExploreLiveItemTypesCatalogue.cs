using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class KeywordsGoogleTrendsExploreLiveItemTypesCatalogue : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("google_trends_graph", "Google trends graph"),
        new("google_trends_map", "Google trends map"),
        new("google_trends_topics_list", "Google trends topics list"),
        new("google_trends_queries_list", "Google trends queries list")
    ];
}
