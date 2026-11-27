using Blackbird.Applications.Sdk.Common.Dictionaries;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.DataForSEO.Handlers.Static;

public class ClientOptions8 : IStaticDataSourceItemHandler
{
    public IEnumerable<DataSourceItem> GetData() =>
    [
        new("chrome", "Chrome"),
        new("chrome-omni", "Chrome-omni"),
        new("gws-wiz", "Gws-wiz"),
        new("gws-wiz-serp", "Gws-wiz-SERP"),
        new("safari", "Safari"),
        new("firefox", "Firefox"),
        new("psy-ab", "Psy-ab"),
        new("toolbar", "Toolbar"),
        new("youtube", "Youtube"),
        new("gws-wiz-local", "Gws-wiz-local"),
        new("img", "Img"),
        new("products-cc", "Products-cc")
    ];
}
