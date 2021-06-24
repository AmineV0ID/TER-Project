using System.Windows;
using System.Windows.Controls;
using EMR.Domain;
using EMR.UI.MVVM.ViewModel;

namespace EMR.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for PatientListView.xaml
    /// </summary>
    public partial class PatientListView : UserControl
    {
        public PatientListView()
        {
            InitializeComponent();
            listPatientListBox.ItemsSource = SqliteDataAccess.GetPatients();
            listPatientListBox.DisplayMemberPath = "FullName";
        }

        private void AddPatientButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainViewModel.RelayCommand.Execute("Register");
        }

        private void EditPatientButton_Click(object sender, RoutedEventArgs e)
        {
            if (listPatientListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Patient");
            }
            else
            {
                var patient = (Patient)listPatientListBox.SelectedItem;
                GlobalStaticInformation.Id = patient.Id;
                MainViewModel.RelayCommand.Execute("Update");
            }
        }

        private void DeletePatientButton_Click(object sender, RoutedEventArgs e)
        {
            if (listPatientListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Patient");
            }
            else
            {
                var patient = (Patient)listPatientListBox.SelectedItem;
                SqliteDataAccess.DeletePatient(patient.Id);
                listPatientListBox.ItemsSource = SqliteDataAccess.GetPatients();
            }
        }

        private void SearchPatientButton_Click(object sender, RoutedEventArgs e)
        {
            listPatientListBox.ItemsSource = SqliteDataAccess.GetPatientsByName(SearchBox.Text);
        }  
        private void ReadPatientButton_Click(object sender, RoutedEventArgs e)
        {
            if (listPatientListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Patient");
            }
            else
            {
                var patient = (Patient)listPatientListBox.SelectedItem;
                GlobalStaticInformation.Id = patient.Id;
                MainViewModel.RelayCommand.Execute("Read");
            }
        } 
    }
}
