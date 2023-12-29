using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUI.Project.Presentation.ViewModel
{
  public partial class BaseViewModel : ObservableObject
  {
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    string _title;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _isBusy;

    public bool IsNotBusy => !IsBusy;
  }
}
