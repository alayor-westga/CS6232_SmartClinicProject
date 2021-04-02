using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace SmartClinic.View
{
    /// <summary>
    /// Author:  Mike Hamel
    /// Secondary Author: Alonso Ortego
    /// 
    /// Date:3-12-21
    /// 
    /// Class that manages an update to patient information
    /// </summary>
    public partial class UpdatePatientForm : Form
    {
        private int patientId;
        private ClinicPerson patient;
        private readonly PatientController patientController;
        private readonly Dictionary<string, string> genders;

        /// <summary>
        /// Constructor to instantiate instance variables
        /// </summary>
        public UpdatePatientForm()
        {
            InitializeComponent();
            patientController = new PatientController();
            patient = new ClinicPerson();
            genders = new Dictionary<string, string>()
            {
                { "", "Select a value" },
                { "F", "Female" },
                { "M", "Male" },
                { "X", "Non Binary" },
            };
            genderComboBox.DataSource = new BindingSource(genders, null);
            genderComboBox.DisplayMember = "Value";
            genderComboBox.ValueMember = "Key";
            LoadStateComboBox(this.stateComboBox);
        }

        /// <summary>
        /// method called when view/edit clicked from another page or tab; 
        /// will call helper methods to populate form and show this dialog
        /// </summary>
        /// <param name="patientId"></param>
        public void ShowForPatient(int patientId)
        {
            this.patientId = patientId;
            GetPatientFromDB();
            PopulateForm();
            ShowDialog();
        }

        /// <summary>
        /// helper method that gets one patient from the db basedon on patientID
        /// </summary>
        private void GetPatientFromDB()
        {
            this.patient = this.patientController.GetClinicPerson(patientId);
        }

        /// <summary>
        /// populates the form with data
        /// </summary>
        private void PopulateForm()
        {
            patientIdLabel.Text = "Patient ID: " + patientId.ToString();
            firstNameTextBox.Text = patient.FirstName;
            lastNameTextBox.Text = patient.LastName;
            dateTimePickerForDOB.Value = patient.DateOfBirth;
            genderComboBox.SelectedValue = patient.Gender;
            address1TextBox.Text = patient.Street1;
            address2TextBox.Text = patient.Street2;
            cityTextBox.Text = patient.City;
            stateComboBox.SelectedValue = Enum.Parse(typeof(States), patient.State);
            zipCodeTextBox.Text = patient.ZipCode;
            phoneTextBox.Text = patient.Phone;
            ssnTextBox.Text = patient.SSN;
            MakeAllFieldsReadOnly();
        }

        /// <summary>
        /// locks the form so it cannot be edited
        /// </summary>
        private void MakeAllFieldsReadOnly()
        {
            patientIdLabel.Text = "Patient ID: " + patientId.ToString();
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            dateTimePickerForDOB.Enabled = false;
            genderComboBox.Enabled = false;
            address1TextBox.ReadOnly = true;
            address2TextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            stateComboBox.Enabled = false;
            zipCodeTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            ssnTextBox.ReadOnly = true;
        }

        /// <summary>
        /// enables all form fields so the form can be edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            patientIdLabel.Text = "Patient ID: " + patientId.ToString();
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            dateTimePickerForDOB.Enabled = true;
            genderComboBox.Enabled = true;
            address1TextBox.ReadOnly = false;
            address2TextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            stateComboBox.Enabled = true;
            zipCodeTextBox.ReadOnly = false;
            phoneTextBox.ReadOnly = false;
            ssnTextBox.ReadOnly = false;
        }

        /// <summary>
        /// saves updates to the patient form fields, after input validation performed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;

            ClinicPerson updatedPatient = new ClinicPerson();
            updatedPatient.DateOfBirth = this.dateTimePickerForDOB.Value.Date;
            updatedPatient.Gender = this.genderComboBox.SelectedValue.ToString();
            updatedPatient.FirstName = this.firstNameTextBox.Text;
            updatedPatient.LastName = this.lastNameTextBox.Text;
            updatedPatient.Street1 = this.address1TextBox.Text;
            updatedPatient.Street2 = this.address2TextBox.Text;
            updatedPatient.City = this.cityTextBox.Text;
            updatedPatient.State = this.stateComboBox.SelectedValue.ToString();
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

        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// deletes a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultVerifyClose = MessageBox.Show("Are you sure you want to delete this patient?\n" +
               "This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultVerifyClose == DialogResult.Yes)
            {
                try
                {
                    if (this.patientController.PatientHasNoAppointments(patientId))
                    {
                        this.patientController.DeletePatient(patientId);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This patient has associated appointments\nand cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// clear all error messages on form
        /// </summary>
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
            patientIdLabel.Text = "";
            ssnErrorLabel.Text = "";
        }

        /// <summary>
        /// input validation for form fields
        /// </summary>
        /// <returns></returns>
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
            if (dob.Text.Length == 0)
            {
                isValid = false;
                dobErrorLabel.Text = requiredField;
            }
            if (genderComboBox.SelectedIndex == 0)
            {
                isValid = false;
                genderErrorLabel.Text = requiredField;
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
            if (stateComboBox.SelectedIndex == 0)
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
            Regex ssnRegex = new Regex("[0-9]{9}");
            if (!ssnRegex.IsMatch(ssnTextBox.Text))
            {
                isValid = false;
                ssnErrorLabel.Text = "9 digits required";
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
                return isValid;
            }
            if (ssnTextBox.Text != this.patient.SSN && this.patientController.SsnIsNotUnique(this.ssnTextBox.Text))
            {
                isValid = false;
                ssnErrorLabel.Text = "SSN Assigned to Another Patient";
            }
            return isValid;
        }

        /// <summary>
        /// populates combo box with state codes
        /// </summary>
        /// <param name="cbo"></param>
        public static void LoadStateComboBox(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(States))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbo.DisplayMember = "Description";
            cbo.ValueMember = "value";
        }
    }
}
