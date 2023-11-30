using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using PictureApp.Configuration;
using PictureApp.Models;

namespace PictureApp.Data;

public class PictureService
{
    private readonly GoogleSearchConfig googleConfig;

    public PictureService(IOptions<GoogleSearchConfig> googleConfig)
    {
        this.googleConfig = googleConfig.Value!;
    }
    public async Task<List<Picture>> PickPicturesAsync(string pictureSearch, int count = 20)
    {
        var url =
            "https://www.googleapis.com/customsearch/v1?&cx=c2e87ae15cb6c479b&q=cycling"
                .SetQueryParam("searchType", "image")
                .SetQueryParam("key", googleConfig.ApiKey)
                .SetQueryParam("cx", googleConfig.EngineId)
                .SetQueryParam("q", pictureSearch);
        var results = await url.GetJsonAsync<PictureQueryResults>();
        return results.Items.Take(count).Select(item => new Picture
        {
            ImageUrl = item.Link.ToString(), Description = item.Snippet, 
            Source = item.DisplayLink, FileType = item.FileFormat,
            Width = item.Image.Width, Height = item.Image.Height
        }).ToList();

    }

    
}