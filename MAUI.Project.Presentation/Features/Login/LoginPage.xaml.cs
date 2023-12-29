namespace MAUI.Project.Presentation.Features.Login;

public partial class LoginPage : ContentPage
{
  public LoginPage(LoginPageViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
  }
}