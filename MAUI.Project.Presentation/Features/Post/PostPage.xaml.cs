namespace MAUI.Project.Presentation.Features.Post;

public partial class PostPage : ContentPage
{
  public PostPage(PostPageViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
  }
}