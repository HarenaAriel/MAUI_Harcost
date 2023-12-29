using CommunityToolkit.Maui;
using MAUI.Project.Presentation.Features.Login;
using MAUI.Project.Presentation.Features.Post;
using MAUI.Project.Presentation.ViewModel;

namespace MAUI.Project.Presentation
{
  public static class PresentationServiceRegistrations
  {
    public static IServiceCollection CustomsServices(this IServiceCollection services)
    {
      services.AddTransient<MainPage>();
      services.AddTransient(typeof(MainPageViewModel));

      services.AddTransient<LoginPage>();
      services.AddTransient(typeof(LoginPageViewModel));

      services.AddTransient<PostPage>();
      services.AddTransient(typeof(PostPageViewModel));

      return services;
    }
  }
}
