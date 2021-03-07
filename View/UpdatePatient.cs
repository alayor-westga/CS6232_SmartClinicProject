using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class UpdatePatient : Form
    {
        private readonly int patientID;
        private ClinicPerson patient;
        private readonly PatientController patientController;
        public UpdatePatient(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
            this.patientController = new PatientController();
            this.patient = new ClinicPerson();
            this.GetClinicPerson();
           
        }

        private void PopulateForm()
        {
            this.patientIDLabel.Text = "Patient ID: " + this.patientID.ToString();
            this.firstNameTextBox.Text = this.patient.FirstName;
            this.lastNameTextBox.Text = this.patient.LastName;
            this.dateTimePickerForDOB.Value = this.patient.DateOfBirth;
            this.genderTextBox.Text = this.patient.Gender;
            this.address1TextBox.Text = this.patient.Street1;
            this.address2TextBox.Text = this.patient.Street2;
            this.cityTextBox.Text = this.patient.City;
            this.stateTextBox.Text = this.patient.State;
            this.zipCodeTextBox.Text = this.patient.ZipCode;
            this.phoneTextBox.Text = this.patient.Phone;
            this.MakeAllFieldsReadOnly();

        }

        private void MakeAllFieldsReadOnly()
        {
            this.patientIDLabel.Text = "Patient ID: " + this.patientID.ToString();
            this.firstNameTextBox.ReadOnly = true;
            this.lastNameTextBox.ReadOnly = true;
            this.dateTimePickerForDOB.Enabled = false;
            this.genderTextBox.ReadOnly = true;
            this.address1TextBox.ReadOnly = true;
            this.address2TextBox.ReadOnly = true;
            this.cityTextBox.ReadOnly = true;
            this.stateTextBox.ReadOnly = true;
            this.zipCodeTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;
           
        }

        private void GetClinicPerson()
        {
            
            this.patient = this.patientController.GetClinicPerson(patientID);
            this.PopulateForm();
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            this.patientIDLabel.Text = "Patient ID: " + this.patientID.ToString();
            this.firstNameTextBox.ReadOnly = false;
            this.lastNameTextBox.ReadOnly = false;
            this.dateTimePickerForDOB.Enabled = true;
            this.genderTextBox.ReadOnly = false;
            this.address1TextBox.ReadOnly = false;
            this.address2TextBox.ReadOnly = false;
            this.cityTextBox.ReadOnly = false;
            this.stateTextBox.ReadOnly = false;
            this.zipCodeTextBox.ReadOnly = false;
            this.phoneTextBox.ReadOnly = false;
        }

        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
