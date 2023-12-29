using CommunityToolkit.Mvvm.Input;
using MAUI.Project.Presentation.Features.Login;
using MAUI.Project.Presentation.Features.Post;

namespace MAUI.Project.Presentation.ViewModel
{
  public partial class MainPageViewModel : BaseViewModel
  {
    public MainPageViewModel()
    {
      Title = "Main Page";
    }

    #region Commands

    [RelayCommand]
    async Task GoToLogin()
    {
      await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    [RelayCommand]
    async Task GoToPost()
    {
      await Shell.Current.GoToAsync(nameof(PostPage));
    }

    #endregion
  }
}
