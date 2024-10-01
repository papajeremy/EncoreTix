using EncoreTix.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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
        private List<Attraction> _attractions = new();
        private Attraction _attraction = new();

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

        public async Task<List<Attraction>> GetAttrations( string searchString )
        {
            if ( string.IsNullOrWhiteSpace( searchString ) || _attractions.Count > 0 )
            {
                return _attractions;
            }
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
            var requestUrl = $"attractions.json?apikey={_apiKey}&keyword={searchString}&size=6";
            var response = await _httpClient.GetAsync( requestUrl );
            if ( response.IsSuccessStatusCode )
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var attractionsResult = JsonSerializer.Deserialize<Root>( jsonString );
                if ( attractionsResult.Embedded != null && attractionsResult.Embedded.Attractions.Count > 0 )
                {
                    _attractions = attractionsResult.Embedded.Attractions;
                }
            }
            return _attractions;
        }

        public async Task<Attraction> GetAttraction( string attractionId )
        {
            if ( attractionId != null )
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
                var requestUrl = $"attractions/{attractionId}.json?apikey={_apiKey}";
                var response = await _httpClient.GetAsync( requestUrl );
                if ( response.IsSuccessStatusCode )
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var attractionResult = JsonSerializer.Deserialize<Attraction>( jsonString );
                    if (attractionResult != null )
                    {
                        _attraction = attractionResult;
                    }
                }
            }
            return _attraction;
        }

        
    }
}
