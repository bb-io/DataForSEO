using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class ContentSentimentAnalysisLiveRankScaleCatalogue : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("one_hundred", "One hundred"),
        new("one_thousand", "One thousand")
    ];
}
