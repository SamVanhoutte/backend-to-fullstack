using System.Text.Json.Serialization;

namespace PictureApp.Models;

public partial class Context
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
}