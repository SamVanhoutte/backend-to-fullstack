using System.Text.Json.Serialization;

namespace PictureApp.Shared.Models;

public partial class Queries
{
    [JsonPropertyName("request")]
    public List<NextPage> Request { get; set; }

    [JsonPropertyName("nextPage")]
    public List<NextPage> NextPage { get; set; }
}