using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EMR.Domain;
using EMR.Domain.Helpers;
using EMR.UI.MVVM.ViewModel;

namespace EMR.UI.MVVM.View
{
    /// <summary>
    /// Interaction logic for RegisterPatientView.xaml
    /// </summary>
    public partial class ReadPatientView : UserControl
    {
        public ReadPatientView()
        {
            InitializeComponent();
            InitPatient();
        }

        public void InitPatient()
        {
            var items = genderText.Items;
            items.Add("Male");
            items.Add("Female");
            var id = GlobalStaticInformation.Id;
            GlobalStaticInformation.Id = 0;
            var patient = SqliteDataAccess.GetPatientById(id);
            firstNameText.Text = patient.FirstName;
            lastNameText.Text = patient.LastName;
            ageText.Text = patient.Age.ToString();
            phoneNumberText.Text = patient.PhoneNumber;
            addressText.Text = patient.Address;
            genderText.Text = patient.Gender.ToString();
            heightText.Text = patient.Height.ToString();
            weightText.Text = patient.Weight.ToString();
            diagnos.Text = patient.Diagnos;
        }
    }
}
