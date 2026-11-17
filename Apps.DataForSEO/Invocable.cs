using Apps.DataForSEO.Api;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.DataForSEO;

public class Invocable : BaseInvocable
{
    protected DataForSEOClient Client { get; }

    public Invocable(InvocationContext invocationContext) : base(invocationContext)
    {
        Client = new DataForSEOClient(invocationContext.AuthenticationCredentialsProviders);
    }
}
