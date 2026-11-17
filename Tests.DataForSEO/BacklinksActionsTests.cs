using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class BacklinksActionsTests : TestBase
{
    [TestMethod]
    public async Task BacklinksIndex_ReturnsProviderReport()
    {
        await Run("BacklinksIndex");
    }

    [TestMethod]
    public async Task BacklinksSummaryLive_ReturnsProviderReport()
    {
        await Run("BacklinksSummaryLive");
    }

    [TestMethod]
    public async Task BacklinksHistoryLive_ReturnsProviderReport()
    {
        await Run("BacklinksHistoryLive");
    }

    [TestMethod]
    public async Task BacklinksBacklinksLive_ReturnsProviderReport()
    {
        await Run("BacklinksBacklinksLive");
    }

    [TestMethod]
    public async Task BacklinksAnchorsLive_ReturnsProviderReport()
    {
        await Run("BacklinksAnchorsLive");
    }

    [TestMethod]
    public async Task BacklinksDomainPagesLive_ReturnsProviderReport()
    {
        await Run("BacklinksDomainPagesLive");
    }

    [TestMethod]
    public async Task BacklinksDomainPagesSummaryLive_ReturnsProviderReport()
    {
        await Run("BacklinksDomainPagesSummaryLive");
    }

    [TestMethod]
    public async Task BacklinksReferringDomainsLive_ReturnsProviderReport()
    {
        await Run("BacklinksReferringDomainsLive");
    }

    [TestMethod]
    public async Task BacklinksReferringNetworksLive_ReturnsProviderReport()
    {
        await Run("BacklinksReferringNetworksLive");
    }

    [TestMethod]
    public async Task BacklinksCompetitorsLive_ReturnsProviderReport()
    {
        await Run("BacklinksCompetitorsLive");
    }

    [TestMethod]
    public async Task BacklinksDomainIntersectionLive_ReturnsProviderReport()
    {
        await Run("BacklinksDomainIntersectionLive");
    }

    [TestMethod]
    public async Task BacklinksPageIntersectionLive_ReturnsProviderReport()
    {
        await Run("BacklinksPageIntersectionLive");
    }

    [TestMethod]
    public async Task BacklinksTimeseriesSummaryLive_ReturnsProviderReport()
    {
        await Run("BacklinksTimeseriesSummaryLive");
    }

    [TestMethod]
    public async Task BacklinksTimeseriesNewLostSummaryLive_ReturnsProviderReport()
    {
        await Run("BacklinksTimeseriesNewLostSummaryLive");
    }

    [TestMethod]
    public async Task BacklinksBulkRanksLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkRanksLive");
    }

    [TestMethod]
    public async Task BacklinksBulkBacklinksLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkBacklinksLive");
    }

    [TestMethod]
    public async Task BacklinksBulkSpamScoreLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkSpamScoreLive");
    }

    [TestMethod]
    public async Task BacklinksBulkReferringDomainsLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkReferringDomainsLive");
    }

    [TestMethod]
    public async Task BacklinksBulkNewLostBacklinksLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkNewLostBacklinksLive");
    }

    [TestMethod]
    public async Task BacklinksBulkNewLostReferringDomainsLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkNewLostReferringDomainsLive");
    }

    [TestMethod]
    public async Task BacklinksBulkPagesSummaryLive_ReturnsProviderReport()
    {
        await Run("BacklinksBulkPagesSummaryLive");
    }
}
