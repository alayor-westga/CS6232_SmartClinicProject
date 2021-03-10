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

        /// <summary>
        /// It builds and initializes the appointment view details form.
        /// </summary>
        public AppointmentDetailsForm()
        {
            InitializeComponent();
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
        }
    }
}
