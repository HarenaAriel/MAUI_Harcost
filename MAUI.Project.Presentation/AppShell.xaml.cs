using MAUI.Project.Presentation.Features.Login;
using MAUI.Project.Presentation.Features.Post;

namespace MAUI.Project.Presentation
{
  public partial class AppShell : Shell
  {
    public AppShell()
    {
      InitializeComponent();
      Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
      Routing.RegisterRoute(nameof(PostPage), typeof(PostPage));
    }
  }
}
