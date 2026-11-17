using Apps.DataForSEO.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.DataForSEO.Handlers;

public class CatalogueHandler(InvocationContext context, string endpoint, string kind, string? location, string? platform, string engine)
    : Invocable(context), IAsyncDataSourceItemHandler
{
    public async Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        if (kind == "language" && endpoint.EndsWith("locations_and_languages") && string.IsNullOrWhiteSpace(location))
            return [];
        var response = await Client.Read<CatalogueItemDto>(new RestRequest(endpoint));
        var rows = response.Tasks.SelectMany(x => x.Result ?? []).ToList();
        if (rows.Any(x => x.AvailableLocations != null))
        {
            rows = rows.SelectMany(x => (x.AvailableLocations ?? []).Select(l => new CatalogueItemDto
            {
                LocationCode = l.LocationCode,
                LocationName = l.LocationName,
                LocationType = l.LocationType,
                AvailableLanguages = [new CatalogueLanguageDto { LanguageCode = x.LanguageCode, LanguageName = x.LanguageName }]
            })).GroupBy(x => x.LocationCode).Select(g => new CatalogueItemDto
            {
                LocationCode = g.Key,
                LocationName = g.First().LocationName,
                AvailableLanguages = g.SelectMany(x => x.AvailableLanguages ?? []).ToList()
            }).ToList();
        }
        var items = new List<DataSourceItem>();
        if (kind == "task" && rows.Count >= 1000)
            throw new PluginMisconfigurationException("The provider task queue may be incomplete at 1,000 entries. Map the task ID directly from submission instead of relying on suggestions.");
        foreach (var row in rows)
        {
            if (kind == "location")
            {
                if (platform == "chat_gpt" && endpoint.Contains("llm_mentions") && row.LocationCode != "2840")
                    continue;
                if (!string.IsNullOrEmpty(engine) && row.AvailableLanguages?.Any() == true && !row.AvailableLanguages.Any(x => x.AvailableSources == null || x.AvailableSources.Contains(engine)))
                    continue;
                Add(items, row.LocationCode, $"{row.LocationName} ({row.LocationCode}; {row.LocationType ?? "location"})");
            }
            else if (kind == "language")
            {
                if (endpoint.EndsWith("locations_and_languages"))
                {
                    if (row.LocationCode != location)
                        continue;
                    foreach (var language in row.AvailableLanguages ?? [])
                    {
                        if (platform == "chat_gpt" && endpoint.Contains("llm_mentions") && language.LanguageCode != "en")
                            continue;
                        if (!string.IsNullOrEmpty(engine) && language.AvailableSources != null && !language.AvailableSources.Contains(engine))
                            continue;
                        Add(items, language.LanguageCode, $"{language.LanguageName} ({language.LanguageCode})");
                    }
                }
                else
                    Add(items, row.LanguageCode, $"{row.LanguageName} ({row.LanguageCode})");
            }
            else if (kind == "task")
                Add(items, row.Id, $"{row.Tag ?? row.Id} ({row.Id})");
            else
                Add(items, row.CategoryCode, $"{row.CategoryName} ({row.CategoryCode})");
        }
        var search = context.SearchString ?? string.Empty;
        return items.DistinctBy(x => x.Value).Where(x => x.DisplayName.Contains(search, StringComparison.OrdinalIgnoreCase) || x.Value.Contains(search, StringComparison.OrdinalIgnoreCase)).Take(100).ToList();
    }

    private static void Add(List<DataSourceItem> items, string? value, string display)
    {
        if (!string.IsNullOrWhiteSpace(value))
            items.Add(new DataSourceItem(value, display));
    }
}
