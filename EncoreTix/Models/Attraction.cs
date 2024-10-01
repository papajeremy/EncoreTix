using System.Text.Json.Serialization;

namespace EncoreTix.Models;

public class Attraction
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;
    public string Locale { get; set; } = string.Empty;
    public List<ExternalLink> ExternalLinks { get; set; } = new();
    public List<VenueImage> Images { get; set; } = new();

}

[JsonSerializable( typeof( List<Attraction> ) )]
internal sealed partial class AttractionContext : JsonSerializerContext
{
}

