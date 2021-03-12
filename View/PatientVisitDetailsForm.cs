

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
            this.loggedInNurseTextBox.Text = LoginForm.GetNurse().FirstName.ToString() + " " + 
                LoginForm.GetNurse().LastName.ToString();
            this.loggedInNurseIDTextBox.Text = LoginForm.GetNurse().NurseId.ToString();


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

        private void GetPatientVisit()
        {

            this.visit = this.patientVisitController.GetPatientVisitByAppointmentID(this.visit.AppointmentID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearErrorMessages()
        {
            symptomsMessageLabel.Text = "";
            initialDiagnosisMessageLabel.Text = "";
            bloodPressureLabel.Text = "";
            pulseMessageLabel.Text = "";
            weightMessageLabel.Text = "";
            finalDiagnosisMessageLabel.Text = "";
            temperatureMessageLabel.Text = "";         
        }


        private bool ValidateFields()
        {
            string requiredField = "Required Field";
            var isValid = true;
            if (symptomsTextBox.Text.Length == 0)
            {
                isValid = false;
                symptomsMessageLabel.Text = requiredField;
            }
            if (initialDiagnosisTextBox.Text.Length == 0)
            {
                isValid = false;
                initialDiagnosisLabel.Text = requiredField;
            }
            if (weightTextBox.Text.Length == 0)
            {
                isValid = false;
                weightMessageLabel.Text = requiredField;
            }
            if (tempTextBox.Text.Length == 0)
            {
                isValid = false;
                temperatureLabel.Text = requiredField;
            }
            if (systolicTextBox.Text.Length == 0)
            {
                isValid = false;
                bloodPressureLabel.Text = requiredField;
            }         
            if (diastolicTextBox.Text.Length == 0)
            {
                isValid = false;
                bloodPressureLabel.Text = requiredField;
            }
            if (pulseTextBox.Text.Length == 0)
            {
                isValid = false;
                pulseMessageLabel.Text = requiredField;
            }
            return isValid;
        }
    }
}

