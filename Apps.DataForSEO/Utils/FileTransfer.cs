using Blackbird.Applications.Sdk.Common.Exceptions;
using Blackbird.Applications.Sdk.Common.Files;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;

namespace Apps.DataForSEO.Utils;

public static class FileTransfer
{
    public static async Task<FileReference> Upload(IFileManagementClient files, Stream stream, string contentType, string name)
    {
        try
        {
            return await files.UploadAsync(stream, contentType, name);
        }
        catch (Exception ex) when (ex is not PluginApplicationException && ex is not PluginMisconfigurationException)
        {
            throw new PluginApplicationException("Could not save the report file in Blackbird. Provider requests may already have been charged; retrieve existing task results instead of repeating submission.");
        }
    }

    public static async Task<FileReference> DownloadScreenshot(IFileManagementClient files, string url, string name)
    {
        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) || uri.Scheme != "https" || uri.Host != "api.dataforseo.com" || !uri.AbsolutePath.StartsWith("/cdn/", StringComparison.Ordinal))
            throw new PluginApplicationException("The screenshot URL is outside the documented DataForSEO storage location. Retrieve the original URL from the provider before retrying.");
        try
        {
            using var handler = new HttpClientHandler { AllowAutoRedirect = false };
            using var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(120) };
            using var response = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            if (!response.IsSuccessStatusCode)
                throw new PluginApplicationException("Could not download the DataForSEO screenshot. The temporary link may have expired; check the existing task before creating another screenshot.");
            var contentType = response.Content.Headers.ContentType?.MediaType ?? "application/octet-stream";
            var extension = contentType switch { "image/png" => ".png", "image/jpeg" => ".jpg", "image/webp" => ".webp", _ => ".bin" };
            await using var stream = await response.Content.ReadAsStreamAsync();
            return await Upload(files, stream, contentType, name + extension);
        }
        catch (Exception ex) when (ex is HttpRequestException or IOException or TaskCanceledException)
        {
            throw new PluginApplicationException("The screenshot download could not finish. Check the existing task and its temporary link before requesting another paid screenshot.");
        }
    }

    public static async Task<List<string>> ReadLines(IFileManagementClient files, FileReference file)
    {
        try
        {
            using var stream = await files.DownloadAsync(file);
            using var reader = new StreamReader(stream);
            var lines = new List<string>();
            while (await reader.ReadLineAsync() is { } line)
                if (!string.IsNullOrWhiteSpace(line))
                    lines.Add(line.Trim());
            return lines;
        }
        catch (Exception ex) when (ex is not PluginApplicationException && ex is not PluginMisconfigurationException)
        {
            throw new PluginMisconfigurationException("Could not read the input file. Supply an accessible UTF-8 text file with one value per line.");
        }
    }
}
