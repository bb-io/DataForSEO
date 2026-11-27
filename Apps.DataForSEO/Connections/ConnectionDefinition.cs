using Apps.DataForSEO.Constants;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;

namespace Apps.DataForSEO.Connections;

public class ConnectionDefinition : IConnectionDefinition
{
    public IEnumerable<ConnectionPropertyGroup> ConnectionPropertyGroups =>
    [
        new()
        {
            Name = "API credentials",
            AuthenticationType = ConnectionAuthenticationType.Undefined,
            ConnectionProperties =
            [
                new(CredsNames.Login) { DisplayName = "API login" },
                new(CredsNames.Password) { DisplayName = "API password", Sensitive = true },
                new(CredsNames.Environment)
                {
                    DisplayName = "Environment",
                    Description = "Production requests may incur charges. Sandbox returns test data.",
                    DataItems = [new("production", "Production"), new("sandbox", "Sandbox")]
                }
            ]
        }
    ];

    public IEnumerable<AuthenticationCredentialsProvider> CreateAuthorizationCredentialsProviders(Dictionary<string, string> values)
        => values.Select(x => new AuthenticationCredentialsProvider(x.Key, x.Value)).ToList();
}
