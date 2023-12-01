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
            },
            Typography = new Typography
            {
                Default = new Default() {FontFamily = new[] {"Arial, RobotoDraft, Helvetica, Arial, sans-serif"}},
                H1 = new H1
                {
                    FontSize = "3.5rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                },
                H2 = new H2
                {
                    FontSize = "3rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                },
                H3 = new H3
                {
                    FontSize = "2.5rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                },
                H4 = new H4
                {
                    FontSize = "2rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                },
                H5 = new H5
                {
                    FontSize = "1.5rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                },
                H6 = new H6
                {
                    FontSize = "1.25rem", FontFamily = new[] {"Helvetica, RobotoDraft, Helvetica, Arial, sans-serif"}
                }
            }
        };
}