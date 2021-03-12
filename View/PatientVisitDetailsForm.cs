

using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class PatientVisitDetailsForm : Form
    {

        private PatientVisits visit;
        private readonly AppointmentController appointmentController;
        private readonly PatientVisitController patientVisitController;
        public PatientVisitDetailsForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            this.patientVisitController = new PatientVisitController();
            this.visit = new PatientVisits();
        }

        public void ShowForPatientVisit(PatientVisits visit)
        {

            this.visit = visit;
            PopulateForm();
            ShowDialog();
        }

        /*
        private void GetPatientVisit()
        {
            this.visit = this.patientVisitController.GetPatientVisit(this.visit.AppointmentID);
        }
        */
        private void PopulateForm()
        {
            this.apptIDTextBox.Text = this.visit.AppointmentID.ToString();
            this.patientIDTextBox.Text = this.visit.PatientID.ToString();
            this.patientNameTextBox.Text = this.visit.Patient.ToString();
            this.dobTextBox.Text = this.visit.DateOfBirth.ToString();
            this.doctorTextBox.Text = this.visit.Doctor.ToString();
            this.nurseTextBox.Text = this.visit.Nurse.ToString();
            this.appointmentDateTextBox.Text = this.visit.VisitDate.ToString();
            this.doctorIDTextBox.Text = this.visit.DoctorID.ToString();
            this.doctorPhoneTextBox.Text = this.visit.DoctorPhone.ToString();
            this.lastNurseIDTextBox.Text = this.visit.NurseID.ToString();
            this.symptomsTextBox.Text = this.visit.Symptoms.ToString();
            this.weightTextBox.Text = this.visit.Weight.ToString();
            this.tempTextBox.Text = this.visit.BodyTemperature.ToString();
            this.systolicTextBox.Text = this.visit.SystolicBP.ToString();
            this.diastolicTextBox.Text = this.visit.DiastolicBP.ToString();
            this.pulseTextBox.Text = this.visit.Pulse.ToString();
            this.initialDiagnosisTextBox.Text = this.visit.InitialDiagnosis.ToString();
            this.finalDiagnosisTextBox.Text = this.visit.FinalDiagnosis.ToString();

            MakeAllFieldsReadOnly();
        }

        private void MakeAllFieldsReadOnly()
        {

            this.symptomsTextBox.ReadOnly = true;
            this.weightTextBox.ReadOnly = true;
            this.tempTextBox.ReadOnly = true;
            this.systolicTextBox.ReadOnly = true;
            this.diastolicTextBox.ReadOnly = true;
            this.pulseTextBox.ReadOnly = true;
            this.initialDiagnosisTextBox.ReadOnly = true;
            this.finalDiagnosisTextBox.ReadOnly = true;

        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {

            this.symptomsTextBox.ReadOnly = false;
            this.weightTextBox.ReadOnly = false;
            this.tempTextBox.ReadOnly = false;
            this.systolicTextBox.ReadOnly = false;
            this.diastolicTextBox.ReadOnly = false;
            this.pulseTextBox.ReadOnly = false;
            this.initialDiagnosisTextBox.ReadOnly = false;
            this.finalDiagnosisTextBox.ReadOnly = false;

        }

        internal void ShowWithAppointment(PatientVisits patientVisits)
        {
            throw new NotImplementedException();
        }


/*
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;

            PatientVisits updatedPatientVisit = new PatientVisits();

            updatedPatientVisit.Symptoms = this.symptomsTextBox.Text;
            updatedPatientVisit.Weight = Decimal.Parse(weightTextBox.Text);
            updatedPatientVisit.BodyTemperature = Decimal.Parse(tempTextBox.Text);
            updatedPatientVisit.SystolicBP = Int32.Parse(systolicTextBox.Text);
            updatedPatientVisit.DiastolicBP = Int32.Parse(diastolicTextBox.Text);
            updatedPatientVisit.Pulse = Int32.Parse(pulseTextBox.Text);
            updatedPatientVisit.InitialDiagnosis = initialDiagnosisTextBox.Text;
            updatedPatientVisit.FinalDiagnosis = finalDiagnosisTextBox.Text;


            try
            {
                if (!this.patientVisitController.UpdatePatientVisitInformation(this.visit, updatedPatientVisit))
                {
                    MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
                    + "\n\nThe form has been updated to reflect those changes.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.GetPatientVisit();
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

        private void ClearErrorMessages()
        {
            //dobErrorLabel.Text = "";

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
*/

    }
}

