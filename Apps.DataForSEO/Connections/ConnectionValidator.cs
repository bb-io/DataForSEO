using Apps.DataForSEO.Api;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.DataForSEO.Connections;

public class ConnectionValidator(InvocationContext invocationContext) : BaseInvocable(invocationContext), IConnectionValidator
{
    public async ValueTask<ConnectionValidationResponse> ValidateConnection(IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders, CancellationToken cancellationToken)
    {
        try
        {
            using var client = new DataForSEOClient(authenticationCredentialsProviders, validateProduction: true);
            await client.ExecuteWithErrorHandling(new RestRequest("/v3/appendix/user_data"));
            return new() { IsValid = true, Message = "Success" };
        }
        catch (Exception ex)
        {
            return new() { IsValid = false, Message = ex.Message };
        }
    }
}
