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
    [JsonPropertyName( "attractions" )]
    public List<Attraction> Attractions { get; set; }
}

public class Genre
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}

public class Links
{
    [JsonPropertyName( "self" )]
    public Self Self { get; set; }
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
}

public class SubGenre
{
    [JsonPropertyName( "id" )]
    public string Id { get; set; }

    [JsonPropertyName( "name" )]
    public string Name { get; set; }
}