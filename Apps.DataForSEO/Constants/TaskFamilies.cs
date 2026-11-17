using Blackbird.Applications.Sdk.Common.Exceptions;

namespace Apps.DataForSEO.Constants;

public static class TaskFamilies
{
    public static IReadOnlyDictionary<string, TaskFamily> Values { get; } = new Dictionary<string, TaskFamily>
    {
        ["serp/google/organic"] = new("SERP google organic", "/v3/serp/google/organic/tasks_ready", "/v3/serp/google/organic/task_get/advanced/{id}", true),
        ["serp/google/ai_mode"] = new("SERP google ai mode", "/v3/serp/google/ai_mode/tasks_ready", "/v3/serp/google/ai_mode/task_get/advanced/{id}", true),
        ["serp/google/maps"] = new("SERP google maps", "/v3/serp/google/maps/tasks_ready", "/v3/serp/google/maps/task_get/advanced/{id}", true),
        ["serp/google/local_finder"] = new("SERP google local finder", "/v3/serp/google/local_finder/tasks_ready", "/v3/serp/google/local_finder/task_get/advanced/{id}", true),
        ["serp/google/news"] = new("SERP google news", "/v3/serp/google/news/tasks_ready", "/v3/serp/google/news/task_get/advanced/{id}", true),
        ["serp/google/images"] = new("SERP google images", "/v3/serp/google/images/tasks_ready", "/v3/serp/google/images/task_get/advanced/{id}", true),
        ["serp/google/search_by_image"] = new("SERP google search by image", "/v3/serp/google/search_by_image/tasks_ready", "/v3/serp/google/search_by_image/task_get/advanced/{id}", true),
        ["serp/google/autocomplete"] = new("SERP google autocomplete", "/v3/serp/google/autocomplete/tasks_ready", "/v3/serp/google/autocomplete/task_get/advanced/{id}", true),
        ["serp/bing/organic"] = new("SERP bing organic", "/v3/serp/bing/organic/tasks_ready", "/v3/serp/bing/organic/task_get/advanced/{id}", true),
        ["serp/youtube/video_info"] = new("SERP youtube video info", "/v3/serp/youtube/video_info/tasks_ready", "/v3/serp/youtube/video_info/task_get/advanced/{id}", true),
        ["serp/youtube/organic"] = new("SERP youtube organic", "/v3/serp/youtube/organic/tasks_ready", "/v3/serp/youtube/organic/task_get/advanced/{id}", true),
        ["serp/yahoo/organic"] = new("SERP yahoo organic", "/v3/serp/yahoo/organic/tasks_ready", "/v3/serp/yahoo/organic/task_get/advanced/{id}", true),
        ["serp/baidu/organic"] = new("SERP baidu organic", "/v3/serp/baidu/organic/tasks_ready", "/v3/serp/baidu/organic/task_get/advanced/{id}", true),
        ["serp/naver/organic"] = new("SERP naver organic", "/v3/serp/naver/organic/tasks_ready", "/v3/serp/naver/organic/task_get/advanced/{id}", true),
        ["serp/seznam/organic"] = new("SERP seznam organic", "/v3/serp/seznam/organic/tasks_ready", "/v3/serp/seznam/organic/task_get/advanced/{id}", true),
        ["keywords_data/google_ads/search_volume"] = new("Keywords data google ads search volume", "/v3/keywords_data/google_ads/search_volume/tasks_ready", "/v3/keywords_data/google_ads/search_volume/task_get/{id}", true),
        ["keywords_data/google_ads/keywords_for_site"] = new("Keywords data google ads keywords for site", "/v3/keywords_data/google_ads/keywords_for_site/tasks_ready", "/v3/keywords_data/google_ads/keywords_for_site/task_get/{id}", true),
        ["keywords_data/google_ads/keywords_for_keywords"] = new("Keywords data google ads keywords for keywords", "/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready", "/v3/keywords_data/google_ads/keywords_for_keywords/task_get/{id}", true),
        ["keywords_data/google_trends/explore"] = new("Keywords data google trends explore", "/v3/keywords_data/google_trends/explore/tasks_ready", "/v3/keywords_data/google_trends/explore/task_get/{id}", true),
        ["keywords_data/bing/search_volume"] = new("Keywords data bing search volume", "/v3/keywords_data/bing/search_volume/tasks_ready", "/v3/keywords_data/bing/search_volume/task_get/{id}", true),
        ["keywords_data/bing/keywords_for_site"] = new("Keywords data bing keywords for site", "/v3/keywords_data/bing/keywords_for_site/tasks_ready", "/v3/keywords_data/bing/keywords_for_site/task_get/{id}", true),
        ["keywords_data/bing/keywords_for_keywords"] = new("Keywords data bing keywords for keywords", "/v3/keywords_data/bing/keywords_for_keywords/tasks_ready", "/v3/keywords_data/bing/keywords_for_keywords/task_get/{id}", true),
        ["keywords_data/bing/keyword_performance"] = new("Keywords data bing keyword performance", "/v3/keywords_data/bing/keyword_performance/tasks_ready", "/v3/keywords_data/bing/keyword_performance/task_get/{id}", true),
        ["keywords_data/bing/search_volume_history"] = new("Keywords data bing search volume history", "/v3/keywords_data/bing/search_volume_history/tasks_ready", "/v3/keywords_data/bing/search_volume_history/task_get/{id}", true),
        ["ai_optimization/chat_gpt/llm_scraper"] = new("Ai optimization chat gpt LLM scraper", "/v3/ai_optimization/chat_gpt/llm_scraper/tasks_ready", "/v3/ai_optimization/chat_gpt/llm_scraper/task_get/advanced/{id}", true),
        ["ai_optimization/gemini/llm_scraper"] = new("Ai optimization gemini LLM scraper", "/v3/ai_optimization/gemini/llm_scraper/tasks_ready", "/v3/ai_optimization/gemini/llm_scraper/task_get/advanced/{id}", true),
        ["on_page"] = new("On page", "/v3/on_page/tasks_ready", "/v3/on_page/summary/{id}", true),
        ["on_page/lighthouse"] = new("On page lighthouse", "/v3/on_page/lighthouse/tasks_ready", "/v3/on_page/lighthouse/task_get/json/{id}", true)
    };

    public static TaskFamily Get(string? key)
    {
        if (!Values.TryGetValue(key ?? "serp/google/organic", out var family))
            throw new PluginMisconfigurationException("Select a supported task family.");
        return family;
    }
}
