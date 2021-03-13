using SmartClinic.Controller;
using SmartClinic.Model;
using System;
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

        public void ShowForNewPatientVisit(PatientVisits visit)
        {
            this.visit = visit;
            PopulateHeaderInformation();
            ShowDialog();
        }

        public void ShowForExistingPatientVisit(PatientVisits visit)
        {
            this.visit = visit;
            PopulateHeaderInformation();
            PopulateVisitInformation();
            ShowDialog();
        }
       
        private void PopulateHeaderInformation()
        {
            this.apptIDTextBox.Text = this.visit.AppointmentID.ToString();
            this.patientIDTextBox.Text = this.visit.PatientID.ToString();
            this.patientNameTextBox.Text = this.visit.Patient.ToString();
            this.dobTextBox.Text = this.visit.DateOfBirth.ToString();
            this.doctorTextBox.Text = this.visit.Doctor.ToString();
            this.appointmentDateTextBox.Text = this.visit.VisitDate.ToString();
            this.doctorIDTextBox.Text = this.visit.DoctorID.ToString();
            this.doctorPhoneTextBox.Text = this.visit.DoctorPhone.ToString();
            this.loggedInNurseTextBox.Text = LoginForm.GetNurse().FirstName.ToString() + " " +
                LoginForm.GetNurse().LastName.ToString();
            this.loggedInNurseIDTextBox.Text = LoginForm.GetNurse().NurseId.ToString();
            MakeAllFieldsReadOnly();
        }

        private void PopulateVisitInformation()
        {
            this.nurseTextBox.Text = this.visit.Nurse.ToString();
            this.lastNurseIDTextBox.Text = this.visit.NurseID.ToString();
            this.symptomsTextBox.Text = this.visit.Symptoms.ToString();
            this.weightTextBox.Text = this.visit.Weight.ToString();
            this.tempTextBox.Text = this.visit.BodyTemperature.ToString();
            this.systolicTextBox.Text = this.visit.SystolicBP.ToString();
            this.diastolicTextBox.Text = this.visit.DiastolicBP.ToString();
            this.pulseTextBox.Text = this.visit.Pulse.ToString();
            this.initialDiagnosisTextBox.Text = this.visit.InitialDiagnosis.ToString();
            this.finalDiagnosisTextBox.Text = this.visit.FinalDiagnosis.ToString();
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

        private void ClearErrorMessages()
        {
            symptomsMessageLabel.Text = "";
            initialDiagnosisMessageLabel.Text = "";
            bloodPressureMessageLabel.Text = "";
            pulseMessageLabel.Text = "";
            weightMessageLabel.Text = "";
            finalDiagnosisMessageLabel.Text = "";
            temperatureMessageLabel.Text = "";
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
     
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            this.ClearErrorMessages();
            if (!this.ValidateFields()) return;

            PatientVisits patientVisit = new PatientVisits();

            patientVisit.AppointmentID = this.visit.AppointmentID;
            patientVisit.NurseID = LoginForm.GetNurse().NurseId;
            patientVisit.Symptoms = this.symptomsTextBox.Text;
            patientVisit.Weight = Decimal.Parse(weightTextBox.Text);
            patientVisit.BodyTemperature = Decimal.Parse(tempTextBox.Text);
            patientVisit.SystolicBP = Int32.Parse(systolicTextBox.Text);
            patientVisit.DiastolicBP = Int32.Parse(diastolicTextBox.Text);
            patientVisit.Pulse = Int32.Parse(pulseTextBox.Text);
            patientVisit.InitialDiagnosis = initialDiagnosisTextBox.Text;
            patientVisit.FinalDiagnosis = finalDiagnosisTextBox.Text;

            if (this.patientVisitController.AppointmentHasNoAssociatedVisit(this.visit.AppointmentID))
            {
                this.patientVisitController.AddPatientVisit(patientVisit);
                this.Close();
            }
            else
            {
                try
                {
                    if (!this.patientVisitController.UpdatePatientVisitInformation(this.visit, patientVisit))
                    {
                        MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
                        + "\n\nThe form has been updated to reflect those changes.",
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.GetPatientVisit();
                        this.PopulateHeaderInformation();
                        this.PopulateVisitInformation();
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
        }

        private void GetPatientVisit()
        {

            this.visit = this.patientVisitController.GetPatientVisitByAppointmentID(this.visit.AppointmentID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {         
            var isValid = true;
            if (symptomsTextBox.Text.Length == 0)
            {
                isValid = false;
                symptomsMessageLabel.Text = "Required Field";
            }
            if (initialDiagnosisTextBox.Text.Length == 0)
            {
                isValid = false;
                initialDiagnosisMessageLabel.Text = "Required Field";
            }
            if (weightTextBox.Text.Length == 0)
            {
                isValid = false;
                weightMessageLabel.Text = "Required Field";
            }
            if (!decimal.TryParse(weightTextBox.Text, out _))
            {
                isValid = false;
                weightMessageLabel.Text = "Number Required";
            }
            if (tempTextBox.Text.Length == 0)
            {
                isValid = false;
                temperatureMessageLabel.Text = "Required Field";
            }
            if (!decimal.TryParse(tempTextBox.Text, out _))
            {
                isValid = false;
                temperatureMessageLabel.Text = "Number Required";
            }
            if (systolicTextBox.Text.Length == 0)
            {
                isValid = false;
                bloodPressureMessageLabel.Text = "Required Field";
            }

            if (!int.TryParse(systolicTextBox.Text, out _))
            {
                isValid = false;
                bloodPressureMessageLabel.Text = "Integer Required";
            }
            if (diastolicTextBox.Text.Length == 0)
            {
                isValid = false;
                bloodPressureMessageLabel.Text = "Required Field";
            }
            if (!int.TryParse(diastolicTextBox.Text, out _))
            {
                isValid = false;
                bloodPressureMessageLabel.Text = "Integer Required";
            }
            if (pulseTextBox.Text.Length == 0)
            {
                isValid = false;
                pulseMessageLabel.Text = "Required Field";
            }
            if (!int.TryParse(pulseTextBox.Text, out _))
            {
                isValid = false;
                pulseMessageLabel.Text = "Integer Required";
            }
            return isValid;
        }
    }
}

