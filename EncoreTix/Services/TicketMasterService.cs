using EncoreTix.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EncoreTix.Services
{
    public class TicketMasterService
    {
        private readonly IConfiguration? _configuration;
        private HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _url;

        public TicketMasterService( IConfiguration configuration )
        {
            _configuration = configuration;
            _apiKey = _configuration?.GetValue<string>( "ApiKey" ) ?? string.Empty;
            _url = _configuration?.GetValue<string>( "TicketMasterBaseUrl" ) ?? string.Empty;
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri( _url )
            };            
        }

        public async Task<List<Attraction>> GetAttrationsAsync( string searchString )
        {
            List<Attraction> attractions = new();
            if ( string.IsNullOrWhiteSpace( searchString ) || attractions.Count > 0 )
            {
                return attractions;
            }
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
            var requestUrl = $"attractions.json?apikey={_apiKey}&keyword={searchString}&size=6";
            var response = await _httpClient.GetAsync( requestUrl );
            if ( response.IsSuccessStatusCode )
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var attractionsResult = JsonSerializer.Deserialize<Root>( jsonString, new JsonSerializerOptions(){
                    UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
                } );
                if ( attractionsResult.Embedded != null && attractionsResult.Embedded.Attractions.Count > 0 )
                {
                    attractions = attractionsResult.Embedded.Attractions;
                }
            }
            return attractions;
        }

        public async Task<AttractionEvent> GetAttractionEventAsync( string attractionName )
        {
            AttractionEvent attracionEvent = new();
            if ( attractionName != null )
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
                var requestUrl = $"events.json?apikey={_apiKey}&keyword={attractionName}&size=4";
                var response = await _httpClient.GetAsync( requestUrl );
                if ( response.IsSuccessStatusCode )
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var attractionEventResult = JsonSerializer.Deserialize<AttractionEvent>( jsonString, new JsonSerializerOptions()
                    {
                        UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip
                    } );
                    if (attractionEventResult != null )
                    {
                        attracionEvent = attractionEventResult;
                    }
                }
            }
            return attracionEvent;
        }

        
    }
}
