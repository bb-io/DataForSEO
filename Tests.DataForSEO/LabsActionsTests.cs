using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class LabsActionsTests : TestBase
{
    [TestMethod]
    public async Task LabsGoogleAvailableHistory_ReturnsProviderReport()
    {
        await Run("LabsGoogleAvailableHistory");
    }

    [TestMethod]
    public async Task LabsGoogleKeywordsForSiteLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleKeywordsForSiteLive");
    }

    [TestMethod]
    public async Task LabsGoogleRelatedKeywordsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleRelatedKeywordsLive");
    }

    [TestMethod]
    public async Task LabsGoogleKeywordSuggestionsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleKeywordSuggestionsLive");
    }

    [TestMethod]
    public async Task LabsGoogleKeywordIdeasLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleKeywordIdeasLive");
    }

    [TestMethod]
    public async Task LabsGoogleBulkKeywordDifficultyLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleBulkKeywordDifficultyLive");
    }

    [TestMethod]
    public async Task LabsGoogleSearchIntentLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleSearchIntentLive");
    }

    [TestMethod]
    public async Task LabsGoogleCategoriesForDomainLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleCategoriesForDomainLive");
    }

    [TestMethod]
    public async Task LabsGoogleCategoriesForKeywordsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleCategoriesForKeywordsLive");
    }

    [TestMethod]
    public async Task LabsGoogleKeywordsForCategoriesLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleKeywordsForCategoriesLive");
    }

    [TestMethod]
    public async Task LabsGoogleDomainMetricsByCategoriesLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleDomainMetricsByCategoriesLive");
    }

    [TestMethod]
    public async Task LabsGoogleTopSearchesLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleTopSearchesLive");
    }

    [TestMethod]
    public async Task LabsGoogleRankedKeywordsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleRankedKeywordsLive");
    }

    [TestMethod]
    public async Task LabsGoogleSerpCompetitorsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleSerpCompetitorsLive");
    }

    [TestMethod]
    public async Task LabsGoogleCompetitorsDomainLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleCompetitorsDomainLive");
    }

    [TestMethod]
    public async Task LabsGoogleDomainIntersectionLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleDomainIntersectionLive");
    }

    [TestMethod]
    public async Task LabsGoogleSubdomainsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleSubdomainsLive");
    }

    [TestMethod]
    public async Task LabsGoogleRelevantPagesLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleRelevantPagesLive");
    }

    [TestMethod]
    public async Task LabsGoogleDomainRankOverviewLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleDomainRankOverviewLive");
    }

    [TestMethod]
    public async Task LabsGoogleHistoricalSerpsLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleHistoricalSerpsLive");
    }

    [TestMethod]
    public async Task LabsGoogleHistoricalRankOverviewLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleHistoricalRankOverviewLive");
    }

    [TestMethod]
    public async Task LabsGooglePageIntersectionLive_ReturnsProviderReport()
    {
        await Run("LabsGooglePageIntersectionLive");
    }

    [TestMethod]
    public async Task LabsGoogleHistoricalSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleHistoricalSearchVolumeLive");
    }

    [TestMethod]
    public async Task LabsGoogleBulkTrafficEstimationLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleBulkTrafficEstimationLive");
    }

    [TestMethod]
    public async Task LabsGoogleHistoricalBulkTrafficEstimationLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleHistoricalBulkTrafficEstimationLive");
    }

    [TestMethod]
    public async Task LabsGoogleHistoricalKeywordDataLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleHistoricalKeywordDataLive");
    }

    [TestMethod]
    public async Task LabsGoogleKeywordOverviewLive_ReturnsProviderReport()
    {
        await Run("LabsGoogleKeywordOverviewLive");
    }

    [TestMethod]
    public async Task LabsAmazonBulkSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonBulkSearchVolumeLive");
    }

    [TestMethod]
    public async Task LabsAmazonRelatedKeywordsLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonRelatedKeywordsLive");
    }

    [TestMethod]
    public async Task LabsAmazonRankedKeywordsLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonRankedKeywordsLive");
    }

    [TestMethod]
    public async Task LabsAmazonProductRankOverviewLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonProductRankOverviewLive");
    }

    [TestMethod]
    public async Task LabsAmazonProductCompetitorsLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonProductCompetitorsLive");
    }

    [TestMethod]
    public async Task LabsAmazonProductKeywordIntersectionsLive_ReturnsProviderReport()
    {
        await Run("LabsAmazonProductKeywordIntersectionsLive");
    }
}
