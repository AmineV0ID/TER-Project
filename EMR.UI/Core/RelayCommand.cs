using System;
using System.Windows.Input;
using EMR.Domain;
using EMR.UI.MVVM.ViewModel;

namespace EMR.UI.Core
{
    public class RelayCommand : ICommand
    {
        private MainViewModel ViewModel;
        public RelayCommand(MainViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Home":
                    ViewModel.CurrentView = new HomeViewModel();
                    break;
                case "Register":
                    ViewModel.CurrentView = new RegisterPatientViewModel();
                    break;
                case "Listing":
                    ViewModel.CurrentView = new PatientListViewModel();
                    break;
                case "Update":
                    ViewModel.CurrentView = new EditPatientViewModel();
                    break;
                case "Settings":
                    ViewModel.CurrentView = new SettingsViewModel();
                    break;
                case "Diagnostic":
                    ViewModel.CurrentView = new DiagnosPatientViewModel();
                    break;
                case "Read":
                    ViewModel.CurrentView = new ReadPatientViewModel();
                    break;

            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
