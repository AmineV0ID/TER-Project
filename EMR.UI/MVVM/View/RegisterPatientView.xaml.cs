using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EMR.Domain;
using EMR.Domain.Helpers;

namespace EMR.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for RegisterPatientView.xaml
    /// </summary>
    public partial class RegisterPatientView : UserControl
    {

        List<Patient> patient = new List<Patient>();



        public RegisterPatientView()
        {
            InitializeComponent();

            LoadPatientList();
            var items = genderText.Items;
            items.Add("Male");
            items.Add("Female");
            genderText.Text = (string)items[0];
        }

        private void LoadPatientList()
        {
            patient = SqliteDataAccess.GetPatients();

            WireUpPatientList();
        }

        private void WireUpPatientList()
        {

            listPatientListBox.ItemsSource = patient;
            listPatientListBox.DisplayMemberPath = "FullName";
        }

        private void RefreshListButton_Click(object sender, RoutedEventArgs e)
        {
            LoadPatientList();
            MessageBox.Show("List Refreshed");
        }

        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = ageText.Text.ToInt(),
                PhoneNumber = phoneNumberText.Text,
                Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum),genderText.Text),
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
                SqliteDataAccess.SavePatient(p);
                firstNameText.Text = "";
                lastNameText.Text = "";
                ageText.Text = "";
                phoneNumberText.Text = "";
                addressText.Text = "";
                genderText.Text = "";
                heightText.Text = "";
                weightText.Text = "";

                MessageBox.Show("Patient Added");
            }
        }
    }
}
