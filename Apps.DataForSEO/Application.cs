using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Metadata;

namespace Apps.DataForSEO;

public class Application : IApplication, ICategoryProvider
{
    public string Name => "DataForSEO";

    public IEnumerable<ApplicationCategory> Categories
    {
        get => [ApplicationCategory.Marketing];
        set { }
    }

    public T GetInstance<T>() => throw new NotImplementedException();
}
