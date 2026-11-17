using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class KeywordsActionsTests : TestBase
{
    [TestMethod]
    public async Task KeywordsGoogleAdsSearchVolumeTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsSearchVolumeTaskPost");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsSearchVolumeTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsSearchVolumeTaskGet");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsSearchVolumeLive");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForSiteTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForSiteTaskPost");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForSiteTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForSiteTaskGet");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForSiteLive_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForSiteLive");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForKeywordsTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForKeywordsTaskPost");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForKeywordsTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForKeywordsTaskGet");
    }

    [TestMethod]
    public async Task KeywordsGoogleAdsKeywordsForKeywordsLive_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleAdsKeywordsForKeywordsLive");
    }

    [TestMethod]
    public async Task KeywordsGoogleTrendsExploreTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleTrendsExploreTaskPost");
    }

    [TestMethod]
    public async Task KeywordsGoogleTrendsExploreTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleTrendsExploreTaskGet");
    }

    [TestMethod]
    public async Task KeywordsGoogleTrendsExploreLive_ReturnsProviderReport()
    {
        await Run("KeywordsGoogleTrendsExploreLive");
    }

    [TestMethod]
    public async Task KeywordsDataForSEOTrendsExploreLive_ReturnsProviderReport()
    {
        await Run("KeywordsDataForSEOTrendsExploreLive");
    }

    [TestMethod]
    public async Task KeywordsDataForSEOTrendsSubregionInterestsLive_ReturnsProviderReport()
    {
        await Run("KeywordsDataForSEOTrendsSubregionInterestsLive");
    }

    [TestMethod]
    public async Task KeywordsDataForSEOTrendsDemographyLive_ReturnsProviderReport()
    {
        await Run("KeywordsDataForSEOTrendsDemographyLive");
    }

    [TestMethod]
    public async Task KeywordsDataForSEOTrendsMergedDataLive_ReturnsProviderReport()
    {
        await Run("KeywordsDataForSEOTrendsMergedDataLive");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeTaskPost");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeTaskGet");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeLive");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForSiteTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForSiteTaskPost");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForSiteTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForSiteTaskGet");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForSiteLive_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForSiteLive");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForKeywordsTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForKeywordsTaskPost");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForKeywordsTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForKeywordsTaskGet");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordsForKeywordsLive_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordsForKeywordsLive");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordPerformanceTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordPerformanceTaskPost");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordPerformanceTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordPerformanceTaskGet");
    }

    [TestMethod]
    public async Task KeywordsBingKeywordPerformanceLive_ReturnsProviderReport()
    {
        await Run("KeywordsBingKeywordPerformanceLive");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeHistoryTaskPost_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeHistoryTaskPost");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeHistoryTaskGet_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeHistoryTaskGet");
    }

    [TestMethod]
    public async Task KeywordsBingSearchVolumeHistoryLive_ReturnsProviderReport()
    {
        await Run("KeywordsBingSearchVolumeHistoryLive");
    }

    [TestMethod]
    public async Task KeywordsClickstreamDataDataForSEOSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("KeywordsClickstreamDataDataForSEOSearchVolumeLive");
    }

    [TestMethod]
    public async Task KeywordsClickstreamDataGlobalSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("KeywordsClickstreamDataGlobalSearchVolumeLive");
    }

    [TestMethod]
    public async Task KeywordsClickstreamDataBulkSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("KeywordsClickstreamDataBulkSearchVolumeLive");
    }
}
