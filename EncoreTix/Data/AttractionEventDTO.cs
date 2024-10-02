using EncoreTix.Models;
using EncoreTix.ViewModels;

namespace EncoreTix.Data;

public class AttractionEventDTO
{
    public List<EventViewModel> ConvertToEventVmListDTO( AttractionEvent attractionEvent )
    {
        var eventVmList = new List<EventViewModel>();
        foreach(var em in attractionEvent.Embedded.Events)
        {
            var eventVm = new EventViewModel();
            eventVm.Id = em.Id;
            eventVm.Name = em.Name;
            eventVm.StartDate = DateTime.Parse(em.Dates.Start.LocalDate);
            eventVm.Venue = em.Embedded?.Venues?.FirstOrDefault().Name ?? string.Empty;
            eventVm.Location = $"{em.Embedded?.Venues.First().City.Name}, {em.Embedded?.Venues.First().State.Name}";
            eventVm.ImageUrl = em.Embedded?.Venues?.SelectMany( v => v.Images ).First().Url ?? string.Empty;
            eventVm.HomePageUrl = em.Embedded?.Attractions?.Select( a => a.ExternalLinks ).First().Homepage?.FirstOrDefault().Url ?? string.Empty;
            eventVm.LastFmUrl = em.Embedded?.Attractions?.Select( a => a.ExternalLinks ).First().Lastfm?.FirstOrDefault().Url ?? string.Empty;
            eventVm.YouTubeUrl = em.Embedded?.Attractions?.Select( a => a.ExternalLinks ).First().Youtube?.FirstOrDefault().Url ?? string.Empty;
            eventVm.TwitterUrl = em.Embedded?.Attractions?.Select( a => a.ExternalLinks ).First().Twitter?.FirstOrDefault().Url ?? string.Empty;
            eventVmList.Add(eventVm);
        }              

        return eventVmList;
    }
}
