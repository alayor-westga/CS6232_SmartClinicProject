using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class NewPatientForm : Form
    {
        private readonly PatientController patientController;
        public NewPatientForm()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;
            
            try
            {
                ClinicPerson newPatient = new ClinicPerson();
                newPatient.DateOfBirth = this.dateTimePickerForDOB.Value.Date;
                newPatient.Gender = this.genderTextBox.Text;
                newPatient.FirstName = this.firstNameTextBox.Text;
                newPatient.LastName = this.lastNameTextBox.Text;
                newPatient.Street1 = this.address1TextBox.Text;
                newPatient.Street2 = this.address2TextBox.Text;
                newPatient.City = this.cityTextBox.Text;
                newPatient.State = this.stateTextBox.Text;
                newPatient.ZipCode = this.zipCodeTextBox.Text;
                newPatient.Phone = this.phoneTextBox.Text;
                newPatient.SSN = this.ssnTextBox.Text;

                int clinicPersonID = this.patientController.AddClinicPerson(newPatient);
                this.patientIDLabel.Text = "Patient ID: " + this.patientController.AddPatient(clinicPersonID).ToString();

                MessageBox.Show("The patient was successfully added to the database.",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException argumentException)
            {
                this.DisplayError(argumentException);
            }
        }

        private void ClearErrorMessages()
        {
            this.dobErrorLabel.Text = "";
            this.genderErrorLabel.Text = "";
            this.firstNameErrorLabel.Text = "";
            this.lastNameErrorLabel.Text = "";
            this.address1ErrorLabel.Text = "";
            this.cityErrorLabel.Text = "";
            this.stateErrorLabel.Text = "";
            this.zipCodeErrorLabel.Text = "";
            this.phoneErrorLabel.Text = "";
            this.patientIDLabel.Text = "";
            this.ssnErrorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void DisplayError(Exception errorMessage)
        {
            MessageBox.Show(errorMessage.Message,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateFields()
        {
            string requiredField = "This field is required";
            var isValid = true;
            if (this.firstNameTextBox.Text.Length == 0)
            {
                isValid = false;
                this.firstNameErrorLabel.Text = requiredField;
            }
            if (this.lastNameTextBox.Text.Length == 0)
            {
                isValid = false;
                this.lastNameErrorLabel.Text = requiredField;
            }
            if (this.dobLabel.Text.Length == 0)
            {
                isValid = false;
                this.dobErrorLabel.Text = requiredField;
            }
            if (!(this.genderTextBox.Text == "M" || this.genderTextBox.Text == "F" || this.genderTextBox.Text == "X"))
            {
                isValid = false;
                this.genderErrorLabel.Text = "Accepts 'M', 'F' or 'X'";
            }
            if (this.address1TextBox.Text.Length == 0)
            {
                isValid = false;
                this.address1ErrorLabel.Text = requiredField;
            }
            if (this.cityTextBox.Text.Length == 0)
            {
                isValid = false;
                this.cityErrorLabel.Text = requiredField;
            }
            Regex stateRegex = new Regex("[A-Z]{2}");
            if (!stateRegex.IsMatch(stateTextBox.Text))
            {
                isValid = false;
                this.stateErrorLabel.Text = "2 letter state code requried";
            }
            if (this.stateTextBox.Text.Length != 2)
            {
                isValid = false;
                this.stateErrorLabel.Text = "2 letter state code required";
            }
            if (this.stateTextBox.Text.Length == 0)
            {
                isValid = false;
                this.stateErrorLabel.Text = requiredField;
            }
            if (this.zipCodeTextBox.Text.Length == 0)
            {
                isValid = false;
                this.zipCodeErrorLabel.Text = requiredField;
            }
            Regex phoneRegex = new Regex("[0-9]{10}");
            if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                isValid = false;
                this.phoneErrorLabel.Text = "only 10 numbers permitted";
            }
            if (this.phoneTextBox.Text.Length != 10)
            {
                isValid = false;
                this.phoneErrorLabel.Text = "10 digits required";
            }
            if (this.phoneTextBox.Text.Length == 0)
            {
                isValid = false;
                this.phoneErrorLabel.Text = requiredField;
            }
            if (this.ssnTextBox.Text.Length != 9)
            {
                isValid = false;
                this.ssnErrorLabel.Text = "9 digits required";
            }
            if (this.ssnTextBox.Text.Length == 0)
            {
                isValid = false;
                this.ssnErrorLabel.Text = requiredField;
            }
            return isValid;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.dateTimePickerForDOB.Value = DateTime.Now;
            this.genderTextBox.Text = "";
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateTextBox.Text = "";
            this.zipCodeTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.ssnTextBox.Text = "";
            this.ClearErrorMessages();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            this.ClearForm();
        }
    }


}
