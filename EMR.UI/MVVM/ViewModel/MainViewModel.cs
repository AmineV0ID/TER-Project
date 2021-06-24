using System.Windows.Input;
using EMR.UI.Core;

namespace EMR.UI.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private static BaseViewModel _currentView = new HomeViewModel();

        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public static ICommand RelayCommand { get; set; }

        public MainViewModel()
        {
            RelayCommand = new RelayCommand(this);
        }
    }
}
