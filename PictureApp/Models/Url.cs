using System.Text.Json.Serialization;

namespace PictureApp.Models;

public partial class Url
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("template")]
    public string Template { get; set; }
}