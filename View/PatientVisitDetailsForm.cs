using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Windows.Forms;

namespace SmartClinic.View
{
    /// <summary>
    /// It shows the patient details form.
    /// </summary>
    public partial class PatientVisitDetailsForm : Form
    {
        private PatientVisits visit;
        private readonly AppointmentController appointmentController;
        private readonly PatientVisitController patientVisitController;

        /// <summary>
        /// It builds and initializes the patient details form.
        /// </summary>
        public PatientVisitDetailsForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            patientVisitController = new PatientVisitController();
            visit = new PatientVisits();
        }


        /// <summary>
        /// It renders the form for a new visit.
        /// <param name="visit">The visit details to be rendered.</param>
        /// </summary>
        public void ShowForNewPatientVisit(PatientVisits visit)
        {
            this.visit = visit;
            PopulateHeaderInformation();
            ClearVisitInformation();
            this.labTestsButton.Enabled = false;
            ShowDialog();
        }

        /// <summary>
        /// It renders the form for an existing visit.
        /// <param name="visit">The visit details to be rendered.</param>
        /// </summary>
        public void ShowForExistingPatientVisit(PatientVisits visit)
        {
            this.visit = visit;
            PopulateHeaderInformation();
            PopulateVisitInformation();
            ShowDialog();
        }
       
        private void PopulateHeaderInformation()
        {
            apptIDTextBox.Text = visit.AppointmentID.ToString();
            patientIDTextBox.Text = visit.PatientID.ToString();
            patientNameTextBox.Text = visit.Patient.ToString();
            dobTextBox.Text = visit.DateOfBirth.ToString();
            doctorTextBox.Text = visit.Doctor.ToString();
            appointmentDateTextBox.Text = visit.VisitDate.ToString();
            doctorIDTextBox.Text = visit.DoctorID.ToString();
            
            string patientPhone = visit.PatientPhone.ToString();
            patientPhoneTextBox.Text = "(" + patientPhone.Substring(0, 3) + ") " + patientPhone.Substring(3, 3) + " - " + patientPhone.Substring(6, 4);

            User user = LoginController.GetUser();
            loggedInNurseTextBox.Text = user.FullName;
            loggedInNurseIDTextBox.Text = user.UserId.ToString();
            MakeAllFieldsReadOnly();
        }

        private void PopulateVisitInformation()
        {
            nurseTextBox.Text = visit.Nurse;
            lastNurseIDTextBox.Text = visit.NurseID.ToString();
            symptomsTextBox.Text = visit.Symptoms;
            weightTextBox.Text = visit.Weight.ToString();
            tempTextBox.Text = visit.BodyTemperature.ToString();
            systolicTextBox.Text = visit.SystolicBP.ToString();
            diastolicTextBox.Text = visit.DiastolicBP.ToString();
            pulseTextBox.Text = visit.Pulse.ToString();
            initialDiagnosisTextBox.Text = visit.InitialDiagnosis;
            finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
        }

        private void ClearVisitInformation()
        {
            nurseTextBox.Text = "";
            lastNurseIDTextBox.Text = "";
            symptomsTextBox.Text = "";
            weightTextBox.Text = "";
            tempTextBox.Text = "";
            systolicTextBox.Text = "";
            diastolicTextBox.Text = "";
            pulseTextBox.Text = "";
            initialDiagnosisTextBox.Text = "";
            finalDiagnosisTextBox.Text = "";
        }

        private void MakeAllFieldsReadOnly()
        {
            symptomsTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            tempTextBox.ReadOnly = true;
            systolicTextBox.ReadOnly = true;
            diastolicTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            initialDiagnosisTextBox.ReadOnly = true;
            finalDiagnosisTextBox.ReadOnly = true;
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
            if(!ValidateFinalDiagnosis())
            {
                return;
            }
            symptomsTextBox.ReadOnly = false;
            weightTextBox.ReadOnly = false;
            tempTextBox.ReadOnly = false;
            systolicTextBox.ReadOnly = false;
            diastolicTextBox.ReadOnly = false;
            pulseTextBox.ReadOnly = false;
            initialDiagnosisTextBox.ReadOnly = false;
            finalDiagnosisTextBox.ReadOnly = false;
            saveChangesAndCloseButton.Enabled = true;
            
        }

        private bool ValidateFinalDiagnosis()
        {
            if (!String.IsNullOrWhiteSpace(visit.FinalDiagnosis))
            {
                MessageBox.Show("This visit info cannot be edited. The final diagnosis has been made.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
     
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("in save changes");
            ClearErrorMessages();
            if (!ValidateFields()) return;

            PatientVisits patientVisit = new PatientVisits();

            patientVisit.AppointmentID = this.visit.AppointmentID;
            patientVisit.NurseID = LoginController.GetUser().UserId;
            patientVisit.Symptoms = symptomsTextBox.Text;
            patientVisit.Weight = decimal.Parse(weightTextBox.Text);
            patientVisit.BodyTemperature = decimal.Parse(tempTextBox.Text);
            patientVisit.SystolicBP = int.Parse(systolicTextBox.Text);
            patientVisit.DiastolicBP = int.Parse(diastolicTextBox.Text);
            patientVisit.Pulse = int.Parse(pulseTextBox.Text);
            patientVisit.InitialDiagnosis = initialDiagnosisTextBox.Text;
            patientVisit.FinalDiagnosis = finalDiagnosisTextBox.Text;

            try
            {
                if (patientVisitController.AppointmentHasNoAssociatedVisit(visit.AppointmentID))
                {
                    try
                    {
                        patientVisitController.AddPatientVisit(patientVisit);
                        MessageBox.Show("The visit information was successfully saved.",
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.labTestsButton.Enabled = true;
                        Close();
                    }
                    catch (ArgumentException argumentException)
                    {
                        MessageBox.Show(argumentException.Message,
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        if (!patientVisitController.UpdatePatientVisitInformation(visit, patientVisit))
                        {
                            MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
                            + "\n\nThe form has been updated to reflect those changes.",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            GetPatientVisit();
                            PopulateHeaderInformation();
                            PopulateVisitInformation();
                            return;
                        }
                        MessageBox.Show("The changes were successfully amended to the database.",
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (ArgumentException argumentException)
                    {
                        MessageBox.Show(argumentException.Message,
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetPatientVisit()
        {
            visit = patientVisitController.GetPatientVisitByAppointmentID(visit.AppointmentID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            Close();
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

        private void AppointmentDetailsButton_Click(object sender, EventArgs e)
        {
            using(AppointmentDetailsForm appointmentDetailsForm = new AppointmentDetailsForm())
            {
                try
                {
                    Appointment appointment = this.appointmentController.GetAppointmentByAppointmentId(this.visit.AppointmentID);
                    appointmentDetailsForm.ShowWithAppointment(appointment);


                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
                               
            }
        }

        private void LabTestsButton_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                
                if (this.patientVisitController.AppointmentHasNoAssociatedVisit(this.visit.AppointmentID))
                {
                    DialogResult dialogResult = MessageBox.Show("This visit has not been saved.\nDo you want to save it?",
                        "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.saveChangesAndCloseButton.PerformClick();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }


            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                */
            
            using (LabTestDetailsForm labTestDetailsForm = new LabTestDetailsForm(visit, finalDiagnosisTextBox.Text == ""))
            {
                labTestDetailsForm.ShowDialog();
            }
        }
    }
}

