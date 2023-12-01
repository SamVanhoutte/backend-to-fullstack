using PictureApp.Shared.Services;

namespace PictureApp.Services;

public class WebAppRuntime : IAppRuntime
{
    public bool IsMobileApp => true;
}