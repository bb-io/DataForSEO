using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class ContentActionsTests : TestBase
{
    [TestMethod]
    public async Task ContentSearchLive_ReturnsProviderReport()
    {
        await Run("ContentSearchLive");
    }

    [TestMethod]
    public async Task ContentContentAnalysisSummaryLive_ReturnsProviderReport()
    {
        await Run("ContentContentAnalysisSummaryLive");
    }

    [TestMethod]
    public async Task ContentSentimentAnalysisLive_ReturnsProviderReport()
    {
        await Run("ContentSentimentAnalysisLive");
    }

    [TestMethod]
    public async Task ContentRatingDistributionLive_ReturnsProviderReport()
    {
        await Run("ContentRatingDistributionLive");
    }

    [TestMethod]
    public async Task ContentPhraseTrendsLive_ReturnsProviderReport()
    {
        await Run("ContentPhraseTrendsLive");
    }

    [TestMethod]
    public async Task ContentCategoryTrendsLive_ReturnsProviderReport()
    {
        await Run("ContentCategoryTrendsLive");
    }
}
