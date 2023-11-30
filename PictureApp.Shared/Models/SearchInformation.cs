using System.Text.Json.Serialization;

namespace PictureApp.Shared.Models;

public partial class SearchInformation
{
    [JsonPropertyName("searchTime")]
    public double SearchTime { get; set; }

    [JsonPropertyName("formattedSearchTime")]
    public string FormattedSearchTime { get; set; }

    [JsonPropertyName("totalResults")]
    public string TotalResults { get; set; }

    [JsonPropertyName("formattedTotalResults")]
    public string FormattedTotalResults { get; set; }
}