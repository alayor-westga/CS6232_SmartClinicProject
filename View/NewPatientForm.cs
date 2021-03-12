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

        public Patient SelectedPatient { get; set; }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;
            
            try
            {
                Patient newPatient = new Patient();
                newPatient.DateOfBirth = dateTimePickerForDOB.Value.Date;
                newPatient.Gender = genderTextBox.Text;
                newPatient.FirstName = firstNameTextBox.Text;
                newPatient.LastName = lastNameTextBox.Text;
                newPatient.Street1 = address1TextBox.Text;
                newPatient.Street2 = address2TextBox.Text;
                newPatient.City = cityTextBox.Text;
                newPatient.State = stateTextBox.Text;
                newPatient.ZipCode = zipCodeTextBox.Text;
                newPatient.Phone = phoneTextBox.Text;
                newPatient.SSN = ssnTextBox.Text;

                int clinicPersonID = patientController.AddClinicPerson(newPatient);
                int patientId = patientController.AddPatient(clinicPersonID);
                patientIDLabel.Text = "Patient ID: " + patientId.ToString();
                newPatient.ClinicPersonID = clinicPersonID;
                newPatient.PatientId = patientId;
                SelectedPatient = newPatient;
                MessageBox.Show("The patient was successfully added to the database.",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException argumentException)
            {
                DisplayError(argumentException);
            }
        }

        private void ClearErrorMessages()
        {
            dobErrorLabel.Text = "";
            genderErrorLabel.Text = "";
            firstNameErrorLabel.Text = "";
            lastNameErrorLabel.Text = "";
            address1ErrorLabel.Text = "";
            cityErrorLabel.Text = "";
            stateErrorLabel.Text = "";
            zipCodeErrorLabel.Text = "";
            phoneErrorLabel.Text = "";
            patientIDLabel.Text = "";
            ssnErrorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           Close();
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
            if (firstNameTextBox.Text.Length == 0)
            {
                isValid = false;
                firstNameErrorLabel.Text = requiredField;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                isValid = false;
                lastNameErrorLabel.Text = requiredField;
            }
            if (dobLabel.Text.Length == 0)
            {
                isValid = false;
                dobErrorLabel.Text = requiredField;
            }
            if (!(genderTextBox.Text == "M" || genderTextBox.Text == "F" || genderTextBox.Text == "X"))
            {
                isValid = false;
                genderErrorLabel.Text = "Accepts 'M', 'F' or 'X'";
            }
            if (address1TextBox.Text.Length == 0)
            {
                isValid = false;
                address1ErrorLabel.Text = requiredField;
            }
            if (cityTextBox.Text.Length == 0)
            {
                isValid = false;
                cityErrorLabel.Text = requiredField;
            }
            Regex stateRegex = new Regex("[A-Z]{2}");
            if (!stateRegex.IsMatch(stateTextBox.Text))
            {
                isValid = false;
                stateErrorLabel.Text = "2 letter state code requried";
            }
            if (stateTextBox.Text.Length != 2)
            {
                isValid = false;
                stateErrorLabel.Text = "2 letter state code required";
            }
            if (stateTextBox.Text.Length == 0)
            {
                isValid = false;
                stateErrorLabel.Text = requiredField;
            }
            if (zipCodeTextBox.Text.Length == 0)
            {
                isValid = false;
                zipCodeErrorLabel.Text = requiredField;
            }
            Regex phoneRegex = new Regex("[0-9]{10}");
            if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                isValid = false;
                phoneErrorLabel.Text = "only 10 numbers permitted";
            }
            if (phoneTextBox.Text.Length != 10)
            {
                isValid = false;
                phoneErrorLabel.Text = "10 digits required";
            }
            if (phoneTextBox.Text.Length == 0)
            {
                isValid = false;
                phoneErrorLabel.Text = requiredField;
            }
            if (ssnTextBox.Text.Length != 9)
            {
                isValid = false;
                ssnErrorLabel.Text = "9 digits required";
            }
            if (ssnTextBox.Text.Length == 0)
            {
                isValid = false;
                ssnErrorLabel.Text = requiredField;
            }
            return isValid;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            dateTimePickerForDOB.Value = DateTime.Now;
            genderTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipCodeTextBox.Text = "";
            phoneTextBox.Text = "";
            ssnTextBox.Text = "";
            ClearErrorMessages();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
    }


}
