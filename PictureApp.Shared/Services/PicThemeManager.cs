using MudBlazor;
using MudBlazor.Utilities;

namespace PictureApp.Shared.Services;

public class PicThemeManager
{
    public static MudTheme DefaultTheme =>
        new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = new MudColor("#132040"), Secondary = new MudColor("#2DD497"),
                Tertiary = new MudColor("#7A87A7"),
                Info = new MudColor("#8995B2")
            }
            ,
            Typography = new Typography
            {
                Default = new Default() {FontFamily = new[] {"Roboto", "Helvetica"}},
                H1 = new H1
                {
                    FontSize = "2.5rem", FontFamily = new[] {"Roboto", "Helvetica"}
                },
                H2 = new H2
                {
                    FontSize = "2rem", FontFamily = new[] {"Roboto", "Helvetica"}
                },
                H3 = new H3
                {
                    FontSize = "2rem", FontFamily = new[] {"Roboto", "Helvetica"}
                },
                H4 = new H4
                {
                    FontSize = "1.8rem", FontFamily = new[] {"Roboto", "Helvetica"}
                },
                H5 = new H5
                {
                    FontSize = "1.5rem", FontFamily = new[] {"Roboto", "Helvetica"}
                },
                H6 = new H6
                {
                    FontSize = "1.25rem", FontFamily = new[] {"Roboto", "Helvetica"}
                }
            }
        };
}