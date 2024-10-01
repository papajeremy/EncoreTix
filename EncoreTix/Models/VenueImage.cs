namespace EncoreTix.Models;

public class VenueImage
{
    public string Ratio { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public int Width { get; set; }
    public int Height { get; set; }
    public string FallBack { get; set; } = string.Empty;
}
