using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class AiVisibilityActionsTests : TestBase
{
    [TestMethod]
    public async Task AiVisibilityChatGptLlmScraperTaskPost_ReturnsProviderReport()
    {
        await Run("AiVisibilityChatGptLlmScraperTaskPost");
    }

    [TestMethod]
    public async Task AiVisibilityChatGptLlmScraperTaskGetAdvanced_ReturnsProviderReport()
    {
        await Run("AiVisibilityChatGptLlmScraperTaskGetAdvanced");
    }

    [TestMethod]
    public async Task AiVisibilityChatGptLlmScraperTaskGetHtml_ReturnsProviderReport()
    {
        await Run("AiVisibilityChatGptLlmScraperTaskGetHtml");
    }

    [TestMethod]
    public async Task AiVisibilityChatGptLlmScraperLiveAdvanced_ReturnsProviderReport()
    {
        await Run("AiVisibilityChatGptLlmScraperLiveAdvanced");
    }

    [TestMethod]
    public async Task AiVisibilityChatGptLlmScraperLiveHtml_ReturnsProviderReport()
    {
        await Run("AiVisibilityChatGptLlmScraperLiveHtml");
    }

    [TestMethod]
    public async Task AiVisibilityGeminiLlmScraperTaskPost_ReturnsProviderReport()
    {
        await Run("AiVisibilityGeminiLlmScraperTaskPost");
    }

    [TestMethod]
    public async Task AiVisibilityGeminiLlmScraperTaskGetAdvanced_ReturnsProviderReport()
    {
        await Run("AiVisibilityGeminiLlmScraperTaskGetAdvanced");
    }

    [TestMethod]
    public async Task AiVisibilityGeminiLlmScraperTaskGetHtml_ReturnsProviderReport()
    {
        await Run("AiVisibilityGeminiLlmScraperTaskGetHtml");
    }

    [TestMethod]
    public async Task AiVisibilityGeminiLlmScraperLiveAdvanced_ReturnsProviderReport()
    {
        await Run("AiVisibilityGeminiLlmScraperLiveAdvanced");
    }

    [TestMethod]
    public async Task AiVisibilityGeminiLlmScraperLiveHtml_ReturnsProviderReport()
    {
        await Run("AiVisibilityGeminiLlmScraperLiveHtml");
    }

    [TestMethod]
    public async Task AiVisibilityAiKeywordDataKeywordsSearchVolumeLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityAiKeywordDataKeywordsSearchVolumeLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsSearchMentionsLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsSearchMentionsLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTargetMetricsLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTargetMetricsLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsMultiTargetMetricsLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsMultiTargetMetricsLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedDomainsLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedDomainsLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedPagesLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedPagesLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedBrandsLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedBrandsLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedBrandCategoriesLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedBrandCategoriesLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTargetMetricsLiteLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTargetMetricsLiteLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedDomainsLiteLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedDomainsLiteLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedPagesLiteLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedPagesLiteLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedBrandsLiteLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedBrandsLiteLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiteLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTopMentionedBrandCategoriesLiteLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsHistoricalLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsHistoricalLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTimeseriesDeltaLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTimeseriesDeltaLive");
    }

    [TestMethod]
    public async Task AiVisibilityLlmMentionsTimeseriesNewLostLive_ReturnsProviderReport()
    {
        await Run("AiVisibilityLlmMentionsTimeseriesNewLostLive");
    }
}
