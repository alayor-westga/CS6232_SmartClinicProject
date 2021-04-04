using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the form to see the appointment details.
    /// </summary>
    public partial class AppointmentDetailsForm : Form
    {
        private Appointment appointment;
        private readonly DoctorController doctorController;
        private readonly AppointmentController appointmentController;
        private readonly PatientVisitController patientVisitController;
        private List<Doctor> doctors;

        /// <summary>
        /// It builds and initializes the appointment view details form.
        /// </summary>
        public AppointmentDetailsForm()
        {
            InitializeComponent();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            patientVisitController = new PatientVisitController();
            doctors = new List<Doctor>();
        }

        /// <summary>
        /// It renders the details form showing info for the provided appoinment.
        /// <param name="appointment">The appointment info to be shown.</param>
        /// </summary>
        public void ShowWithAppointment(Appointment appointment) 
        {
            this.appointment = appointment;
            ShowDialog();
        }

        private void AppointmentDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateDoctors();
            patientIdValueLabel.Text = appointment.PatientId.ToString();
            patientNameValueLabel.Text = appointment.Patient.FullName;
            patientDateOfBirthValueLabel.Text = appointment.Patient.DateOfBirth.ToShortDateString();
            appointmentDatePicker.Value = appointment.Date;
            appointmentTimePicker.Value = appointment.Date;
            doctorComboBox.SelectedValue = appointment.DoctorId;
            doctorPhoneNumberValueLabel.Text = appointment.Doctor.Phone;
            reasonForVisitTextBox.Text = appointment.Reason;
            DisableUIControls();
        }

        private void DisableUIControls()
        {
            appointmentDatePicker.Enabled = false;
            appointmentTimePicker.Enabled = false;
            doctorComboBox.Enabled = false;
            reasonForVisitTextBox.Enabled = false;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void PopulateDoctors()
        {
            doctors.Clear();
            try
            {
                doctors.AddRange(doctorController.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The doctor list could not get loaded.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            doctorComboBox.DataSource = doctors;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(!ValidateUpdateTimeLimit())
            {
                return;
            }
            appointmentDatePicker.Enabled = true;
            appointmentTimePicker.Enabled = true;
            doctorComboBox.Enabled = true;
            reasonForVisitTextBox.Enabled = true;
            saveButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private bool ValidateUpdateTimeLimit()
        {
            TimeSpan difference = appointment.Date - DateTime.Now;
            if (difference.TotalHours < 24)
            {
                MessageBox.Show("The appointment cannot be edited 24 hours prior the appointment date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private DateTime GetCurrentAppointmentDateTime()
        {
            string dateString = appointmentDatePicker.Value.ToShortDateString();
            string timeString = appointmentTimePicker.Value.ToShortTimeString();
            return DateTime.Parse(dateString + " " + timeString);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateUpdateTimeLimit())
            {
                return;
            }
            Appointment appointmentChanges = new Appointment()
            {
                AppointmentId = appointment.AppointmentId,
                Date = GetCurrentAppointmentDateTime(),
                DoctorId = int.Parse(doctorComboBox.SelectedValue.ToString()),
                Reason = reasonForVisitTextBox.Text,
            };
            try
            {
                appointmentController.Update(appointment, appointmentChanges);
                MessageBox.Show("The apointment has been updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The appointment could not get updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!ValidateUpdateTimeLimit())
            {
                return;
            }
            try
            {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this appointment?\n" +
               "This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    appointmentController.Delete(appointment.AppointmentId);
                    MessageBox.Show("The apointment has been deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The appointment could not get deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor selectedDoctor = doctors[doctorComboBox.SelectedIndex];
            doctorPhoneNumberValueLabel.Text = selectedDoctor.Phone;
            doctorIdValueLabel.Text = selectedDoctor.DoctorId.ToString();
        }

        private void PatientVisitDetailsButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.patientVisitController.AppointmentHasNoAssociatedVisit(this.appointment.AppointmentId))
                {
                    PatientVisits appointmentInfoForNewVisit = new PatientVisits();
                    appointmentInfoForNewVisit = this.patientVisitController.GetInfoToCreatNewPatientVisit(this.appointment.AppointmentId);
                    using (PatientVisitDetailsForm patientVisitDetailsForm = new PatientVisitDetailsForm())
                    {
                        patientVisitDetailsForm.ShowForNewPatientVisit(appointmentInfoForNewVisit);
                    }

                }
                else
                {
                    PatientVisits patientVisit = this.patientVisitController.GetPatientVisitByAppointmentID(this.appointment.AppointmentId);
                    using (PatientVisitDetailsForm patientVisitDetailsForm = new PatientVisitDetailsForm())
                    {
                        patientVisitDetailsForm.ShowForExistingPatientVisit(patientVisit);
                    }

                }
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
