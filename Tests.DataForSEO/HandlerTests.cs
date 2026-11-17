using Apps.DataForSEO.Handlers;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class HandlerTests : TestBase
{
    [TestMethod]
    public async Task Locations_SearchesWholeCatalogue()
    {
        var handler = new CatalogueHandler(InvocationContext, "/v3/serp/google/locations", "location", null, null, "");
        var result = (await handler.GetDataAsync(new DataSourceContext { SearchString = "Budapest" }, CancellationToken.None)).ToList();
        Assert.IsTrue(result.Count > 0);
        Assert.IsTrue(result.All(x => x.DisplayName.Contains("Budapest", StringComparison.OrdinalIgnoreCase)));
        Assert.IsTrue(result.All(x => long.TryParse(x.Value, out _)));
    }

    [TestMethod]
    public async Task Languages_RespectLocationAndSource()
    {
        var handler = new CatalogueHandler(InvocationContext, "/v3/dataforseo_labs/locations_and_languages", "language", "2840", null, "google");
        var result = (await handler.GetDataAsync(new DataSourceContext { SearchString = "English" }, CancellationToken.None)).ToList();
        Assert.IsTrue(result.Any(x => x.Value == "en"));
    }

    [TestMethod]
    public async Task Languages_MissingLocation_ReturnsEmpty()
    {
        var handler = new CatalogueHandler(InvocationContext, "/v3/dataforseo_labs/locations_and_languages", "language", null, null, "google");
        Assert.AreEqual(0, (await handler.GetDataAsync(new DataSourceContext(), CancellationToken.None)).Count());
    }

    [TestMethod]
    public async Task Search_UnknownTerm_ReturnsEmpty()
    {
        var handler = new CatalogueHandler(InvocationContext, "/v3/serp/google/locations", "location", null, null, "");
        Assert.AreEqual(0, (await handler.GetDataAsync(new DataSourceContext { SearchString = "no-location-8e820e6f" }, CancellationToken.None)).Count());
    }
}
