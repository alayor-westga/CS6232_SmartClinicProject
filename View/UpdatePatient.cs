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
            this.GetPatientFromDB();
            this.PopulateForm();
        }

        private void GetPatientFromDB()
        {
            this.patient = this.patientController.GetClinicPerson(patientID);
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
            this.ssnTextBox.Text = this.patient.SSN;
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
            this.ssnTextBox.ReadOnly = true;
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
            this.ssnTextBox.ReadOnly = false;
        }

        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;

            ClinicPerson updatedPatient = new ClinicPerson();
            updatedPatient.DateOfBirth = this.dateTimePickerForDOB.Value.Date;
            updatedPatient.Gender = this.genderTextBox.Text;
            updatedPatient.FirstName = this.firstNameTextBox.Text;
            updatedPatient.LastName = this.lastNameTextBox.Text;
            updatedPatient.Street1 = this.address1TextBox.Text;
            updatedPatient.Street2 = this.address2TextBox.Text;
            updatedPatient.City = this.cityTextBox.Text;
            updatedPatient.State = this.stateTextBox.Text;
            updatedPatient.ZipCode = this.zipCodeTextBox.Text;
            updatedPatient.Phone = this.phoneTextBox.Text;
            updatedPatient.SSN = this.ssnTextBox.Text;

            try
            {
                if (!this.patientController.UpdatePatientInformation(this.patient, updatedPatient))
                {
                    MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
                    + "\n\nThe form has been updated to reflect those changes.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.GetPatientFromDB();
                    this.PopulateForm();
                    return;
                }
                MessageBox.Show("The changes were successfully amended to the database.",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultVerifyClose = MessageBox.Show("Are you sure you want to delete this patient?\n" +
               "This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultVerifyClose == DialogResult.Yes)
            {
                if (this.patientController.PatientHasNoAppointments(patientID))
                {
                    //need try-catch
                    this.patientController.DeletePatient(this.patientID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This patient has associated appointments\nand cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (this.dob.Text.Length == 0)
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
    }
}
