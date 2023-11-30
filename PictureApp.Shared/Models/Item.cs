using System.Text.Json.Serialization;

namespace PictureApp.Shared.Models;

public partial class Item
{
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("htmlTitle")]
    public string HtmlTitle { get; set; }

    [JsonPropertyName("link")]
    public Uri Link { get; set; }

    [JsonPropertyName("displayLink")]
    public string DisplayLink { get; set; }

    [JsonPropertyName("snippet")]
    public string Snippet { get; set; }

    [JsonPropertyName("htmlSnippet")]
    public string HtmlSnippet { get; set; }

    [JsonPropertyName("mime")]
    public string Mime { get; set; }

    [JsonPropertyName("fileFormat")]
    public string FileFormat { get; set; }

    [JsonPropertyName("image")]
    public Image Image { get; set; }
}