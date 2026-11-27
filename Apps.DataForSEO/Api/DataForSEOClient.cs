using System.Net;
using System.Text;
using Apps.DataForSEO.Constants;
using Apps.DataForSEO.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polly;
using RestSharp;

namespace Apps.DataForSEO.Api;

public class DataForSEOClient : BlackBirdRestClient
{
    private readonly string[] secrets;

    public DataForSEOClient(IEnumerable<AuthenticationCredentialsProvider> credentials, bool validateProduction = false)
        : base(new RestClientOptions { BaseUrl = GetHost(credentials, validateProduction), MaxTimeout = 180000, FollowRedirects = false })
    {
        var creds = credentials.ToArray();
        var login = creds.FirstOrDefault(x => x.KeyName == CredsNames.Login)?.Value;
        var password = creds.FirstOrDefault(x => x.KeyName == CredsNames.Password)?.Value;
        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            throw new PluginMisconfigurationException("Enter the API login and API password from the DataForSEO API Access page.");
        var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{login}:{password}"));
        secrets = [login, password, token];
        this.AddDefaultHeader("Authorization", $"Basic {token}");
    }

    public override async Task<RestResponse> ExecuteWithErrorHandling(RestRequest request)
    {
        try
        {
            var policy = Policy.HandleResult<RestResponse>(x => request.Method == Method.Get && x.StatusCode == HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(3, (attempt, result, _) => RetryDelay(attempt, result.Result), (_, _, _, _) => Task.CompletedTask);
            var response = await policy.ExecuteAsync(() => ExecuteAsync(request));
            if (!response.IsSuccessStatusCode || response.ResponseStatus != ResponseStatus.Completed)
                throw ConfigureErrorException(response);
            var envelope = JsonConvert.DeserializeObject<EnvelopeDto<JToken>>(response.Content ?? "");
            if (envelope == null)
                throw new PluginApplicationException("DataForSEO returned an empty response. Check provider status before retrying a paid operation.");
            if (envelope.StatusCode != 20000)
                throw ProviderError(envelope.StatusCode, envelope.StatusMessage, null);
            foreach (var task in envelope.Tasks)
                if (task.StatusCode != 20000 && task.StatusCode != 20100 && task.StatusCode != 40601 && task.StatusCode != 40602)
                    throw ProviderError(task.StatusCode, task.StatusMessage, task.Id);
            return response;
        }
        catch (JsonException)
        {
            throw new PluginApplicationException("DataForSEO returned an unreadable response. Check task history before repeating a paid request.");
        }
        catch (HttpRequestException)
        {
            throw new PluginApplicationException("Could not reach DataForSEO. The request may have been accepted; check task history before repeating it.");
        }
        catch (TaskCanceledException)
        {
            throw new PluginApplicationException("DataForSEO timed out. The request may have been accepted; check task history before repeating it.");
        }
    }

    public async Task<EnvelopeDto<T>> Read<T>(RestRequest request)
    {
        var response = await ExecuteWithErrorHandling(request);
        try
        {
            return JsonConvert.DeserializeObject<EnvelopeDto<T>>(response.Content!)!;
        }
        catch (JsonException)
        {
            throw new PluginApplicationException("DataForSEO returned data that could not be read. Check provider status and contact support if this persists.");
        }
    }

    public async Task<List<RestResponse>> Paginate(Func<int, int, string?, RestRequest> createRequest, int maximum, string? cursorField)
    {
        if (maximum < 1)
            throw new PluginMisconfigurationException("Maximum results must be greater than zero.");
        var responses = new List<RestResponse>();
        var offset = 0;
        string? cursor = null;
        while (offset < maximum)
        {
            var size = Math.Min(100, maximum - offset);
            var response = await ExecuteWithErrorHandling(createRequest(offset, size, cursor));
            responses.Add(response);
            var envelope = JsonConvert.DeserializeObject<EnvelopeDto<JObject>>(response.Content!)!;
            var result = envelope.Tasks.SelectMany(x => x.Result ?? []).FirstOrDefault();
            var count = (result?["items"] as JArray)?.Count ?? 0;
            offset += count;
            cursor = cursorField == null ? null : result?[cursorField]?.Value<string>();
            var total = result?["total_count"]?.Value<long?>();
            if (count < size || (total.HasValue && offset >= total.Value))
                break;
        }
        return responses;
    }

    protected override Exception ConfigureErrorException(RestResponse response)
    {
        if (response.ResponseStatus != ResponseStatus.Completed)
            return new PluginApplicationException("Could not complete the DataForSEO request. It may have been accepted; check task history before repeating a paid operation.");
        var status = (int)response.StatusCode;
        if (status == 402)
            return new PluginMisconfigurationException("DataForSEO requires payment. Check your account balance and product access.");
        if (status is 401 or 403)
            return new PluginMisconfigurationException("DataForSEO denied access. Check the API credentials, account access and IP restrictions.");
        if (status is 400 or 404 or 422)
            return new PluginMisconfigurationException($"DataForSEO rejected the request (HTTP {status}). Check the action inputs and selected environment.");
        return new PluginApplicationException($"DataForSEO request failed (HTTP {status}). Check provider status and account limits before retrying.");
    }

    private Exception ProviderError(int code, string message, string? id)
    {
        foreach (var secret in secrets)
            message = message.Replace(secret, "[redacted]", StringComparison.Ordinal);
        message = message.Length > 300 ? message[..300] : message;
        var text = $"DataForSEO ({code}): {message}";
        if (!string.IsNullOrEmpty(id))
            text += $" Task ID: {id}.";
        if (code >= 50000 || code is 40209 or 40202 or 40203)
            return new PluginApplicationException(text + " Check provider status and account request limits.");
        return new PluginMisconfigurationException(text + " Check the action inputs, account balance and product access.");
    }

    private static Uri GetHost(IEnumerable<AuthenticationCredentialsProvider> credentials, bool validateProduction)
    {
        var environment = credentials.FirstOrDefault(x => x.KeyName == CredsNames.Environment)?.Value;
        if (!string.IsNullOrEmpty(environment) && environment != "production" && environment != "sandbox")
            throw new PluginMisconfigurationException("Select Production or Sandbox in the connection.");
        return new Uri(!validateProduction && environment == "sandbox" ? "https://sandbox.dataforseo.com" : "https://api.dataforseo.com");
    }

    private static TimeSpan RetryDelay(int attempt, RestResponse response)
    {
        var value = response.Headers?.FirstOrDefault(x => string.Equals(x.Name, "Retry-After", StringComparison.OrdinalIgnoreCase))?.Value?.ToString();
        if (double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var seconds) && seconds >= 0)
            return TimeSpan.FromSeconds(seconds);
        if (DateTimeOffset.TryParse(value, out var until) && until > DateTimeOffset.UtcNow)
            return until - DateTimeOffset.UtcNow;
        return TimeSpan.FromSeconds(Math.Pow(2, attempt)) + TimeSpan.FromMilliseconds(Random.Shared.Next(500));
    }
}
