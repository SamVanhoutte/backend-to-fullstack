using System.Text.Json.Serialization;

namespace PictureApp.Models;

public partial class NextPage
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("totalResults")]
    public string TotalResults { get; set; }

    [JsonPropertyName("searchTerms")]
    public string SearchTerms { get; set; }

    [JsonPropertyName("count")]
    public long Count { get; set; }

    [JsonPropertyName("startIndex")]
    public long StartIndex { get; set; }

    [JsonPropertyName("inputEncoding")]
    public string InputEncoding { get; set; }

    [JsonPropertyName("outputEncoding")]
    public string OutputEncoding { get; set; }

    [JsonPropertyName("safe")]
    public string Safe { get; set; }

    [JsonPropertyName("cx")]
    public string Cx { get; set; }

    [JsonPropertyName("searchType")]
    public string SearchType { get; set; }
}