using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class AuditsActionsTests : TestBase
{
    [TestMethod]
    public async Task AuditsForceStop_ReturnsProviderReport()
    {
        await Run("AuditsForceStop");
    }

    [TestMethod]
    public async Task AuditsTaskPost_ReturnsProviderReport()
    {
        await Run("AuditsTaskPost");
    }

    [TestMethod]
    public async Task AuditsSummary_ReturnsProviderReport()
    {
        await Run("AuditsSummary");
    }

    [TestMethod]
    public async Task AuditsPages_ReturnsProviderReport()
    {
        await Run("AuditsPages");
    }

    [TestMethod]
    public async Task AuditsPagesByResource_ReturnsProviderReport()
    {
        await Run("AuditsPagesByResource");
    }

    [TestMethod]
    public async Task AuditsResources_ReturnsProviderReport()
    {
        await Run("AuditsResources");
    }

    [TestMethod]
    public async Task AuditsDuplicateTags_ReturnsProviderReport()
    {
        await Run("AuditsDuplicateTags");
    }

    [TestMethod]
    public async Task AuditsDuplicateContent_ReturnsProviderReport()
    {
        await Run("AuditsDuplicateContent");
    }

    [TestMethod]
    public async Task AuditsLinks_ReturnsProviderReport()
    {
        await Run("AuditsLinks");
    }

    [TestMethod]
    public async Task AuditsRedirectChains_ReturnsProviderReport()
    {
        await Run("AuditsRedirectChains");
    }

    [TestMethod]
    public async Task AuditsNonIndexable_ReturnsProviderReport()
    {
        await Run("AuditsNonIndexable");
    }

    [TestMethod]
    public async Task AuditsWaterfall_ReturnsProviderReport()
    {
        await Run("AuditsWaterfall");
    }

    [TestMethod]
    public async Task AuditsKeywordDensity_ReturnsProviderReport()
    {
        await Run("AuditsKeywordDensity");
    }

    [TestMethod]
    public async Task AuditsMicrodata_ReturnsProviderReport()
    {
        await Run("AuditsMicrodata");
    }

    [TestMethod]
    public async Task AuditsUncrawlableResources_ReturnsProviderReport()
    {
        await Run("AuditsUncrawlableResources");
    }

    [TestMethod]
    public async Task AuditsRawHtml_ReturnsProviderReport()
    {
        await Run("AuditsRawHtml");
    }

    [TestMethod]
    public async Task AuditsPageScreenshot_ReturnsProviderReport()
    {
        await Run("AuditsPageScreenshot");
    }

    [TestMethod]
    public async Task AuditsContentParsing_ReturnsProviderReport()
    {
        await Run("AuditsContentParsing");
    }

    [TestMethod]
    public async Task AuditsContentParsingLive_ReturnsProviderReport()
    {
        await Run("AuditsContentParsingLive");
    }

    [TestMethod]
    public async Task AuditsInstantPages_ReturnsProviderReport()
    {
        await Run("AuditsInstantPages");
    }

    [TestMethod]
    public async Task AuditsLighthouseTaskPost_ReturnsProviderReport()
    {
        await Run("AuditsLighthouseTaskPost");
    }

    [TestMethod]
    public async Task AuditsLighthouseTaskGetJson_ReturnsProviderReport()
    {
        await Run("AuditsLighthouseTaskGetJson");
    }

    [TestMethod]
    public async Task AuditsLighthouseLiveJson_ReturnsProviderReport()
    {
        await Run("AuditsLighthouseLiveJson");
    }
}
