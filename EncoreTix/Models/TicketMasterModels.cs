using System.Text.Json.Serialization;

namespace EncoreTix.Models;

public class Attraction
{
    [JsonPropertyName( "name" )]
    public string Name { get; set; }

    [JsonPropertyName( "type" )]
    public string Type { get; set; }

    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "test" )]
    public bool Test { get; set; }

    [JsonPropertyName( "locale" )]
    public string Locale { get; set; }

    [JsonPropertyName( "images" )]
    public List<Image> Images { get; set; }

    [JsonPropertyName( "classifications" )]
    public List<Classification> Classifications { get; set; }

    [JsonPropertyName( "_links" )]
    public Links Links { get; set; }

    [JsonPropertyName( "externalLinks" )]
    public ExternalLinks ExternalLinks { get; set; }
}

public class Classification
{
    [JsonPropertyName( "primary" )]
    public bool Primary { get; set; }

    [JsonPropertyName( "segment" )]
    public Segment Segment { get; set; }

    [JsonPropertyName( "genre" )]
    public Genre Genre { get; set; }

    [JsonPropertyName( "subGenre" )]
    public SubGenre SubGenre { get; set; }
}

public class Embedded
{
    [JsonPropertyName( "events" )]
    public List<AttractionEvent> Events { get; set; }

    [JsonPropertyName( "venues" )]
    public List<Venue> Venues { get; set; }

    [JsonPropertyName( "attractions" )]
    public List<Attraction> Attractions { get; set; }
}

public class ExternalLinks
{
    [JsonPropertyName( "youtube" )]
    public List<Youtube> Youtube { get; set; }

    [JsonPropertyName( "twitter" )]
    public List<Twitter> Twitter { get; set; }

    [JsonPropertyName( "itunes" )]
    public List<Itune> Itunes { get; set; }

    [JsonPropertyName( "lastfm" )]
    public List<Lastfm> Lastfm { get; set; }

    [JsonPropertyName( "facebook" )]
    public List<Facebook> Facebook { get; set; }

    [JsonPropertyName( "wiki" )]
    public List<Wiki> Wiki { get; set; }

    [JsonPropertyName( "instagram" )]
    public List<Instagram> Instagram { get; set; }

    [JsonPropertyName( "musicbrainz" )]
    public List<Musicbrainz> Musicbrainz { get; set; }

    [JsonPropertyName( "homepage" )]
    public List<Homepage> Homepage { get; set; }
}


public class Facebook
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Genre
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}

public class Homepage
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Instagram
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Itune
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Lastfm
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Links
{
    [JsonPropertyName( "self" )]
    public Self Self { get; set; }

    [JsonPropertyName( "next" )]
    public Next Next { get; set; }

    [JsonPropertyName( "venues" )]
    public List<Venue> Venues { get; set; }
}

public class Musicbrainz
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }
}

public class Page
{
    [JsonPropertyName( "size" )]
    public int Size { get; set; }

    [JsonPropertyName( "totalElements" )]
    public int TotalElements { get; set; }

    [JsonPropertyName( "totalPages" )]
    public int TotalPages { get; set; }

    [JsonPropertyName( "number" )]
    public int Number { get; set; }
}

public class Root
{
    [JsonPropertyName( "_links" )]
    public Links Links { get; set; }

    [JsonPropertyName( "_embedded" )]
    public Embedded Embedded { get; set; }

    [JsonPropertyName( "page" )]
    public Page Page { get; set; }
}

public class Segment
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}

public class Self
{
    [JsonPropertyName( "href" )]
    public string Href { get; set; }

    [JsonPropertyName( "templated" )]
    public bool Templated { get; set; }
}

public class SubGenre
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}

public class Twitter
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}


public class Wiki
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}

public class Youtube
{
    [JsonPropertyName( "url" )]
    public string Url { get; set; }
}


public class Image
{
    [JsonPropertyName( "ratio" )]
    public string Ratio { get; set; }

    [JsonPropertyName( "url" )]
    public string Url { get; set; }

    [JsonPropertyName( "width" )]
    public int Width { get; set; }

    [JsonPropertyName( "height" )]
    public int Height { get; set; }

    [JsonPropertyName( "fallback" )]
    public bool Fallback { get; set; }
}

public class Address
{
    [JsonPropertyName( "line1" )]
    public string Line1 { get; set; }
}

public class City
{
    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}

public class Country
{
    [JsonPropertyName( "name" )]
    public string Name { get; set; }

    [JsonPropertyName( "countryCode" )]
    public string CountryCode { get; set; }
}

public class Dates
{
    [JsonPropertyName( "start" )]
    public Start Start { get; set; }

    [JsonPropertyName( "timezone" )]
    public string Timezone { get; set; }

    [JsonPropertyName( "status" )]
    public Status Status { get; set; }
}

public class AttractionEvent
{
    [JsonPropertyName( "name" )]
    public string Name { get; set; }

    [JsonPropertyName( "type" )]
    public string Type { get; set; }

    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "test" )]
    public bool Test { get; set; }

    [JsonPropertyName( "url" )]
    public string Url { get; set; }

    [JsonPropertyName( "locale" )]
    public string Locale { get; set; }

    [JsonPropertyName( "images" )]
    public List<Image> Images { get; set; }

    [JsonPropertyName( "sales" )]
    public Sales Sales { get; set; }

    [JsonPropertyName( "dates" )]
    public Dates Dates { get; set; }

    [JsonPropertyName( "classifications" )]
    public List<Classification> Classifications { get; set; }

    [JsonPropertyName( "promoter" )]
    public Promoter Promoter { get; set; }

    [JsonPropertyName( "_links" )]
    public Links Links { get; set; }

    [JsonPropertyName( "_embedded" )]
    public Embedded Embedded { get; set; }
}

public class Location
{
    [JsonPropertyName( "longitude" )]
    public string Longitude { get; set; }

    [JsonPropertyName( "latitude" )]
    public string Latitude { get; set; }
}

public class Market
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }
}

public class Next
{
    [JsonPropertyName( "href" )]
    public string Href { get; set; }

    [JsonPropertyName( "templated" )]
    public bool Templated { get; set; }
}

public class Promoter
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }
}

public class Public
{
    [JsonPropertyName( "startDateTime" )]
    public DateTime StartDateTime { get; set; }

    [JsonPropertyName( "startTBD" )]
    public bool StartTBD { get; set; }

    [JsonPropertyName( "endDateTime" )]
    public DateTime EndDateTime { get; set; }
}



public class Sales
{
    [JsonPropertyName( "public" )]
    public Public Public { get; set; }
}

public class Start
{
    [JsonPropertyName( "localDate" )]
    public string LocalDate { get; set; }

    [JsonPropertyName( "dateTBD" )]
    public bool DateTBD { get; set; }

    [JsonPropertyName( "dateTBA" )]
    public bool DateTBA { get; set; }

    [JsonPropertyName( "timeTBA" )]
    public bool TimeTBA { get; set; }

    [JsonPropertyName( "noSpecificTime" )]
    public bool NoSpecificTime { get; set; }
}

public class State
{
    [JsonPropertyName( "name" )]
    public string Name { get; set; }

    [JsonPropertyName( "stateCode" )]
    public string StateCode { get; set; }
}

public class Status
{
    [JsonPropertyName( "code" )]
    public string Code { get; set; }
}

public class Venue
{
    [JsonPropertyName( "href" )]
    public string Href { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }

    [JsonPropertyName( "type" )]
    public string Type { get; set; }

    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "test" )]
    public bool Test { get; set; }

    [JsonPropertyName( "locale" )]
    public string Locale { get; set; }

    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }

    [JsonPropertyName( "postalCode" )]
    public string PostalCode { get; set; }

    [JsonPropertyName( "timezone" )]
    public string Timezone { get; set; }

    [JsonPropertyName( "city" )]
    public City City { get; set; }

    [JsonPropertyName( "state" )]
    public State State { get; set; }

    [JsonPropertyName( "country" )]
    public Country Country { get; set; }

    [JsonPropertyName( "address" )]
    public Address Address { get; set; }

    [JsonPropertyName( "location" )]
    public Location Location { get; set; }

    [JsonPropertyName( "markets" )]
    public List<Market> Markets { get; set; }

    [JsonPropertyName( "_links" )]
    public Links Links { get; set; }
}