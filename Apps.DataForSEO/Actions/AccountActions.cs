using Apps.DataForSEO.Models.Dtos;
using Apps.DataForSEO.Models.Requests;
using Apps.DataForSEO.Models.Responses;
using Apps.DataForSEO.Utils;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.DataForSEO.Actions;

[ActionList("Account")]
public class AccountActions(InvocationContext context, IFileManagementClient fileManagementClient) : Invocable(context)
{
    [Action("Get account details", Description = "You will receive detailed information about your API usage, prices, spending and other account details by calling this API.")]
    public async Task<ReportResponse<AppendixUserDataResultInfo>> AccountUserData([ActionParameter] AccountUserDataRequest input)
    {
        var body = new Dictionary<string, object>();
        InputValidator.Validate(body);
        var request = new RestRequest("/v3/appendix/user_data");
        var response = await Client.ExecuteWithErrorHandling(request);
        return await ReportWriter.Write<AppendixUserDataResultInfo>(fileManagementClient, [response], "AccountUserData", false);
    }
}
