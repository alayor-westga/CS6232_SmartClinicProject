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
    public partial class UpdatePatientForm : Form
    {
        private int patientId;
        private ClinicPerson patient;
        private readonly PatientController patientController;
        Dictionary<string, string> genders = new Dictionary<string, string>()
        {
            { "", "Select a value" },
            { "F", "Female" },
            { "M", "Male" },
            { "X", "Non Binary" },
        };
        public UpdatePatientForm()
        {
            InitializeComponent();
            patientController = new PatientController();
            patient = new ClinicPerson();
            genderComboBox.DataSource = new BindingSource(genders, null);
            genderComboBox.DisplayMember = "Value";
            genderComboBox.ValueMember = "Key";
            LoadStateComboBox(this.stateComboBox);
        }

        public void ShowForPatient(int patientId)
        {
            this.patientId = patientId;
            GetPatientFromDB();
            PopulateForm();
            ShowDialog();
        }

        private void GetPatientFromDB()
        {
            this.patient = this.patientController.GetClinicPerson(patientId);
        }

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
            stateComboBox.Text = patient.State;
            zipCodeTextBox.Text = patient.ZipCode;
            phoneTextBox.Text = patient.Phone;
            ssnTextBox.Text = patient.SSN;
            MakeAllFieldsReadOnly();
        }

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
            updatedPatient.State = this.stateComboBox.Text;
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
                if (this.patientController.PatientHasNoAppointments(patientId))
                {
                    //need try-catch
                    this.patientController.DeletePatient(patientId);
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
            if (genderComboBox.SelectedValue.ToString() == "")
            {
                isValid = false;
                genderErrorLabel.Text = "Select a gender";
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
            if (!stateRegex.IsMatch(stateComboBox.Text))
            {
                isValid = false;
                stateErrorLabel.Text = "2 letter state code requried";
            }
            if (stateComboBox.Text.Length != 2)
            {
                isValid = false;
                stateErrorLabel.Text = "2 letter state code required";
            }
            if (stateComboBox.Text.Length == 0)
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
            if (this.patientController.SsnIsNotUnique(this.ssnTextBox.Text))
            {
                isValid = false;
                ssnErrorLabel.Text = "SSN Assigned to Another Patient";
            }
            return isValid;
        }
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
