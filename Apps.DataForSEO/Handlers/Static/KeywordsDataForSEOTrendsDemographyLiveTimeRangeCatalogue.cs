using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class KeywordsDataForSEOTrendsDemographyLiveTimeRangeCatalogue : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("past_4_hours", "Past 4 hours"),
        new("past_day", "Past day"),
        new("past_7_days", "Past 7 days"),
        new("past_30_days", "Past 30 days"),
        new("past_90_days", "Past 90 days"),
        new("past_12_months", "Past 12 months"),
        new("past_5_years", "Past 5 years")
    ];
}
