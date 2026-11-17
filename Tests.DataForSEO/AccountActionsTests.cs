using Tests.DataForSEO.Base;

namespace Tests.DataForSEO;

[TestClass]
public class AccountActionsTests : TestBase
{
    [TestMethod]
    public async Task AccountUserData_ReturnsProviderReport()
    {
        await Run("AccountUserData");
    }
}
