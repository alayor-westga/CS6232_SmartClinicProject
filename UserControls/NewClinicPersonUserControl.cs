using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class NewClinicPersonUserControl : UserControl
    {
        private readonly PatientController patientController;
        private readonly Dictionary<string, string> genders;
        public NewClinicPersonUserControl()
        {
            InitializeComponent();
            this.patientController = new PatientController();
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
        /// It is the new created patient.
        /// </summary>
        public Patient SelectedPatient { get; set; }

        /// <summary>
        /// It sets the parent form.
        /// </summary>
        public Form EnclosingForm { get; set; }

        private static void LoadStateComboBox(ComboBox cbo)
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

        private void AddClinicPersonButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;

            try
            {
                Patient newPatient = new Patient();
                newPatient.DateOfBirth = dateTimePickerForDOB.Value.Date;
                newPatient.Gender = genderComboBox.SelectedValue.ToString();
                newPatient.FirstName = firstNameTextBox.Text;
                newPatient.LastName = lastNameTextBox.Text;
                newPatient.Street1 = address1TextBox.Text;
                newPatient.Street2 = address2TextBox.Text;
                newPatient.City = cityTextBox.Text;
                newPatient.State = stateComboBox.SelectedValue.ToString();
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
                ParentForm.Close();
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
                phoneErrorLabel.Text = "10 digits required";
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
            if (this.patientController.SsnIsNotUnique(this.ssnTextBox.Text))
            {
                isValid = false;
                ssnErrorLabel.Text = "SSN Assigned";
            }
            return isValid;
        }

        private void NewClinicPersonUserControl_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            dateTimePickerForDOB.Value = DateTime.Now;
            genderComboBox.SelectedIndex = 0;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            zipCodeTextBox.Text = "";
            phoneTextBox.Text = "";
            ssnTextBox.Text = "";
            ClearErrorMessages();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void DisplayError(Exception errorMessage)
        {
            MessageBox.Show(errorMessage.Message,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
