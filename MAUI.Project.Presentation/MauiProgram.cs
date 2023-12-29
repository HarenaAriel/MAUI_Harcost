using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MAUI.Project.Presentation
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
      var builder = MauiApp.CreateBuilder();
      builder
        .UseMauiApp<App>()
        .UseMauiCommunityToolkit()
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
          fonts.AddFont("Qiblah.otf", "Qiblah");
          fonts.AddFont("Slight.otf", "Slight");
        });

      builder.Services.CustomsServices();

#if DEBUG
      builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}
