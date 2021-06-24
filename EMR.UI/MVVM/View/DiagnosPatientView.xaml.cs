using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EMR.Domain;
using EMR.Domain.Helpers;

namespace EMR.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for DiagnosPatientView.xaml
    /// </summary>
    public partial class DiagnosPatientView : UserControl
    {
        public DiagnosPatientView()
        {
            InitializeComponent();
            ListPatientListBox.ItemsSource = SqliteDataAccess.GetPatients();
            ListPatientListBox.DisplayMemberPath = "FullName";
            ListDiagnosListBox.ItemsSource = new List<string>()
            {
                "Fever",
                "Cough",
                "Headache",
                "Body Ache",
                "Abdominal Pain",
                "Diarrhoea",
                "Sore Throat",
                "Nausea",
                "Eye Watering",
                "Dizziness",
            };
        }
        private void SearchPatientButton_Click(object sender, RoutedEventArgs e)
        {
            ListPatientListBox.ItemsSource = SqliteDataAccess.GetPatientsByName(SearchBox.Text);
        }
        private void EditPatientButton_Click(object sender, RoutedEventArgs e)
        {
            var patient = (Patient)ListPatientListBox.SelectedItem;
            if (patient == null)
            {
                MessageBox.Show("Veuillez selectionne un patient");
            }
            else
            {
                var listDiagnosis = ListDiagnosListBox.SelectedItems;
                var diagnos = "";
                foreach (var diagno in listDiagnosis)
                {
                    diagnos += $"{diagno},";
                }

                var length = diagnos.Length;
                diagnos = diagnos.Remove(length-1);
                patient.Diagnos = diagnos;
                SqliteDataAccess.EditPatient(patient);
                MessageBox.Show("Diagnos Added");
            }
        }
    }
}
