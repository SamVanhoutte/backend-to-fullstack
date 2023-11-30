using System.Text.Json.Serialization;

namespace PictureApp.Shared.Models;

public partial class Image
{
    [JsonPropertyName("contextLink")] public Uri ContextLink { get; set; }

    [JsonPropertyName("height")] public long Height { get; set; }

    [JsonPropertyName("width")] public long Width { get; set; }

    [JsonPropertyName("byteSize")] public long ByteSize { get; set; }

    [JsonPropertyName("thumbnailLink")] public Uri ThumbnailLink { get; set; }

    [JsonPropertyName("thumbnailHeight")] public long ThumbnailHeight { get; set; }

    [JsonPropertyName("thumbnailWidth")] public long ThumbnailWidth { get; set; }
}