using Apps.DataForSEO.Connections;
using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class ConnectionValidatorTests : TestBase
{
    [TestMethod]
    public async Task ValidCredentials_AreAccepted()
    {
        var result = await new ConnectionValidator(InvocationContext).ValidateConnection(InvocationContext.AuthenticationCredentialsProviders, CancellationToken.None);
        Assert.IsTrue(result.IsValid, result.Message);
    }
}
