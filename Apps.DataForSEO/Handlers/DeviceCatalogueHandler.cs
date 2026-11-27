using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers;

public class DeviceCatalogueHandler(string? device, string field) : IAsyncDataSourceItemHandler
{
    public Task<IEnumerable<DataSourceItem>> GetDataAsync(DataSourceContext context, CancellationToken cancellationToken)
    {
        var mobile = device == "mobile";
        var values = field == "os" ? (mobile ? new[] { "android", "ios" } : ["windows", "macos"])
            : mobile ? ["2", "2.5", "3", "3.5", "4", "4.5"] : ["3.5", "4", "4.5"];
        return Task.FromResult(values.Where(x => x.Contains(context.SearchString ?? string.Empty, StringComparison.OrdinalIgnoreCase)).Select(x => new DataSourceItem(x, x)));
    }
}
