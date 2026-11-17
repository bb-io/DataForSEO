using Blackbird.Applications.Sdk.Common.Files;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;

namespace Tests.DataForSEO.Base;

public class FileManager : IFileManagementClient
{
    public string Folder { get; } = Path.Combine(AppContext.BaseDirectory, "TestFiles", "Output");

    public Task<Stream> DownloadAsync(FileReference reference)
        => Task.FromResult<Stream>(File.OpenRead(Path.Combine(Folder, reference.Name)));

    public async Task<FileReference> UploadAsync(Stream stream, string contentType, string fileName)
    {
        Directory.CreateDirectory(Folder);
        await using var output = File.Create(Path.Combine(Folder, fileName));
        await stream.CopyToAsync(output);
        return new FileReference { Name = fileName, ContentType = contentType };
    }
}
