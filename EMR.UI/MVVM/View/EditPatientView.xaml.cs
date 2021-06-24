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
using EMR.UI.MVVM.ViewModel;

namespace EMR.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for EditPatientView.xaml
    /// </summary>
    public partial class EditPatientView : UserControl
    {
        public string[] Genders { get; set; }
        public EditPatientView()
        {
            InitializeComponent();
            InitPatient();
        }

        private void InitPatient()
        {
            var items = genderText.Items;
            items.Add("Male");
            items.Add("Female");
            var id = GlobalStaticInformation.Id;
            GlobalStaticInformation.Id = 0;
            var patient = SqliteDataAccess.GetPatientById(id);
            idText.Text = patient.Id.ToString();
            firstNameText.Text = patient.FirstName;
            lastNameText.Text = patient.LastName;
            ageText.Text = patient.Age.ToString();
            phoneNumberText.Text = patient.PhoneNumber;
            addressText.Text = patient.Address;
            genderText.Text = patient.Gender.ToString();
            heightText.Text = patient.Height.ToString();
            weightText.Text = patient.Weight.ToString();
        }
        private void EditPatientButton_Click(object sender, RoutedEventArgs e)
        {
   
            if (genderText.Text.HasNoValue())
            {
                genderText.Text = "Male";
            }
            Patient p = new Patient()
            {
                Id = idText.Text.ToInt(),
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = ageText.Text.ToInt(),
                PhoneNumber = phoneNumberText.Text,
                Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), genderText.Text),
                Address = addressText.Text,
                Height = heightText.Text.ToInt(),
                Weight = weightText.Text.ToInt(),
            };
            if (p.FirstName.HasNoValue() || p.LastName.HasNoValue())
            {
                MessageBox.Show("Enter First Name & Last Name !!");
            }
            else
            {
                SqliteDataAccess.EditPatient(p);
                MessageBox.Show("Patient Edited");
            }
        }
    }
}
