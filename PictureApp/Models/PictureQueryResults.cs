using System.Text.Json.Serialization;

namespace PictureApp.Models;

public partial class PictureQueryResults
{
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("url")]
    public Url Url { get; set; }

    [JsonPropertyName("queries")]
    public Queries Queries { get; set; }

    [JsonPropertyName("context")]
    public Context Context { get; set; }

    [JsonPropertyName("searchInformation")]
    public SearchInformation SearchInformation { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}