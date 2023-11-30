using System.Text.Json.Serialization;

namespace PictureApp.Models;

public partial class Queries
{
    [JsonPropertyName("request")]
    public List<NextPage> Request { get; set; }

    [JsonPropertyName("nextPage")]
    public List<NextPage> NextPage { get; set; }
}