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

        /// <summary>
        /// It builds and initializes the appointment view details form.
        /// </summary>
        public AppointmentDetailsForm()
        {
            InitializeComponent();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
        }

        public void ShowWithAppointment(Appointment appointment) 
        {
            this.appointment = appointment;
            ShowDialog();
        }

        private void AppointmentDetailsForm_Load(object sender, EventArgs e)
        {
            patientIdValueLabel.Text = appointment.PatientId.ToString();
            patientNameValueLabel.Text = appointment.Patient.FullName;
            patientDateOfBirthValueLabel.Text = appointment.Patient.DateOfBirth.ToShortDateString();
            appointmentDatePicker.Value = appointment.Date;
            appointmentTimePicker.Value = appointment.Date;
            PopulateDoctors();
            doctorComboBox.SelectedValue = appointment.DoctorId;
            reasonForVisitTextBox.Text = appointment.Reason;
        }

        private void PopulateDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
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

        private void editButton_Click(object sender, EventArgs e)
        {
            appointmentDatePicker.Enabled = true;
            appointmentTimePicker.Enabled = true;
            doctorComboBox.Enabled = true;
            reasonForVisitTextBox.Enabled = true;
            saveButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string dateString = appointmentDatePicker.Value.ToShortDateString();
            string timeString = appointmentTimePicker.Value.ToShortTimeString();
            Appointment appointmentChanges = new Appointment()
            {
                AppointmentId = appointment.AppointmentId,
                Date = DateTime.Parse(dateString + " " + timeString),
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
    }
}
