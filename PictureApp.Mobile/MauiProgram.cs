using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using PictureApp.Mobile.Services;
using PictureApp.Shared.Configuration;
using PictureApp.Shared.Data;
using PictureApp.Shared.Services;

namespace PictureApp.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.Configure<GoogleSearchConfig>(options =>
            builder.Configuration.GetSection("Google").Bind(options));
        builder.Services.AddMudServices();
        builder.Services.AddSingleton<PictureService>();
        builder.Services.AddSingleton<IAppRuntime, MobileAppRuntime>();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif


        return builder.Build();
    }
}