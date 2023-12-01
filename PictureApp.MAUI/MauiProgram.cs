using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MudBlazor.Services;
using PictureApp.MAUI.Services;
using PictureApp.Shared.Configuration;
using PictureApp.Shared.Data;
using PictureApp.Shared.Services;

namespace PictureApp.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Configuration.AddConfiguration(LoadConfiguration());
        
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

        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }

    private static IConfigurationRoot LoadConfiguration()
    {
        var a = Assembly.GetExecutingAssembly();

        var resources = typeof(MauiProgram).Assembly.GetManifestResourceNames();

        using var appSettingsStream = a.GetManifestResourceStream("PictureApp.MAUI.appsettings.json");
        using var appSettingsDevStream = a.GetManifestResourceStream("PictureApp.MAUI.appsettings.Development.json");


        var cfgBuilder = new ConfigurationBuilder();
        if (appSettingsStream != null) cfgBuilder.AddJsonStream(appSettingsStream);
        if (appSettingsDevStream != null) cfgBuilder.AddJsonStream(appSettingsDevStream);

        var config = cfgBuilder.Build();
        return config;
    }
}