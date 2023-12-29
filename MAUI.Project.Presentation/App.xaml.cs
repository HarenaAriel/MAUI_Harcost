namespace MAUI.Project.Presentation
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      MainPage = new AppShell();
    }
  }
}
