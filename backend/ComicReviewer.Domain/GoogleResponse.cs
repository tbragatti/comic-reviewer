namespace ComicReviewer.Domain;

public class GoogleResponse
{
    [System.Text.Json.Serialization.JsonPropertyName("totalItems")]
    public int TotalItems { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("items")]
    public List<BookItem>? Items { get; set; }
}

public class BookItem
{
    [System.Text.Json.Serialization.JsonPropertyName("volumeInfo")]
    public VolumeInfo? VolumeInfo { get; set; }
}

public class VolumeInfo
{
    [System.Text.Json.Serialization.JsonPropertyName("title")]
    public string? Title { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("authors")]
    public List<string>? Authors { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
    public string? PublishedDate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string? Description { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }
}
