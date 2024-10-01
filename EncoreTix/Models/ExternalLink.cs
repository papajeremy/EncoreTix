namespace EncoreTix.Models;

public class ExternalLink
{
    public string Name { get; set; } = string.Empty;
    public List<string> Urls { get; set; } = new();
}
