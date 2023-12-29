using MAUI.Project.Presentation.ViewModel;

namespace MAUI.Project.Presentation
{
  public partial class MainPage : ContentPage
  {
    public MainPage(MainPageViewModel viewModel)
    {
      InitializeComponent();
      BindingContext = viewModel;
    }
  }

}
