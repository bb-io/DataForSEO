namespace Apps.DataForSEO.Events;

public class CompletionMemory
{
    public DateTime LastRead { get; set; }

    public string Scope { get; set; } = string.Empty;

    public List<string> SeenTaskIds { get; set; } = [];
}
