using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoreTix.ViewModels;

public class EventViewModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Venue { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string HomePageUrl { get; set; } = string.Empty;
    public string YouTubeUrl { get; set; } = string.Empty;
    public string TwitterUrl { get; set; } = string.Empty;
    public string LastFmUrl { get; set; } = string.Empty;
}
